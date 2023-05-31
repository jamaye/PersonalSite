using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalSite.Data;
using PersonalSite.Models;
using PersonalSite.Models.ViewModels;

namespace PersonalSite.Pages.Feedback
{
    public class AddModel : PageModel
    {
        private readonly FeedbackDbContext context;
        public AddModel(FeedbackDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public AddFeedbackModel NewFeedback { get; set; }
		public string alertType = string.Empty;
		

        public void OnGet()
        {
        }
        public void OnPost() 
        {

			try
			{
				if (ModelState.IsValid)
				{
					//Convert View Model to Domain model
					var feedbackDomain = new Models.Feedback
					{
						Name = NewFeedback.Name,
						Email = NewFeedback.Email,
						Body = NewFeedback.Body,
						DatePosted = DateTime.Now
					};

					//context.Feedbacks.Add(feedbackDomain);
					//context.SaveChanges();
					Response.Redirect("/Feedback/Success");
				}
				else 
				{
					alertType = "alert-warning";
					ViewData["Message"] = "Error occured. Make sure all fields are completed.";
				}
			}
            catch (Exception ex) 
            {
			}
		}
    }
}
