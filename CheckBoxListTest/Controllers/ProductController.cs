using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CheckBoxListTest.Models;
using System.Web.Mvc.Html;

namespace CheckBoxListTest.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(CheckedList<Product>.GetList());
        }

        [HttpPost]
        public void Index(CheckedList<Product> model)
        {
            
        }
    }

    public static class HtmlHelperExtensions
    {
        public static string CheckBoxList<T, TModel, TValue, TText>(this HtmlHelper<TModel> helper, string listName, string valueProperty, 
            string textProperty, CheckedList<T> checkedList, Func<T, TValue> value, Func<T, TText> text)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < checkedList.Count; i++)
            {
                T item = checkedList.Keys.ToList()[i];
                builder.AppendLine("<p>");
                builder.AppendLine(helper.Hidden(listName + "[" + i + "].Key." + valueProperty, value(item)).ToHtmlString());
                builder.AppendLine(helper.Hidden(listName + "[" + i + "].Key." + textProperty, text(item)).ToHtmlString());
                builder.AppendLine(helper.CheckBox(listName + "[" + i + "].Value", checkedList[item]).ToHtmlString());
                builder.AppendLine(text(item).ToString());
                builder.AppendLine("</p>");
            }
            return builder.ToString();
        }
    }
}
