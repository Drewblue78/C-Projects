using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gallery.Pages
{
    public class ListModel : PageModel
    {
        private ListContext db;
        public List<GroceriesItem> Groceries = new List<GroceriesItem>();

        public ListModel(ListContext db) {
            this.db = db;
        }


        public void OnGet() {
            Groceries = db.Groceries.ToList();

        }
        public void OnPost(int groceriesId, string updatedText) {
            Groceries = db.Groceries.ToList();
            foreach (var item in Groceries) {
                if (item.Id == groceriesId) {
                    item.text = updatedText;
                    break;
                }
            }
            db.SaveChanges();
        }
    }
}