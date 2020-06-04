using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery.Pages {
    public class AddModel : PageModel {
        private ListContext db;

        public AddModel(ListContext db) {
            this.db = db;
        }

        public void OnPost(string text) {
            if (text.Length > 50) text = text.Substring(0, 50);

            var item = new GroceriesItem {
                text = text
            };
            db.Groceries.Add(item);
            db.SaveChanges();
            Response.Redirect("List");
        }
    }
}