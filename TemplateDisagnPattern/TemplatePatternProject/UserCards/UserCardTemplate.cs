using IdentityProject.Models;
using System;
using System.Text;

namespace TemplatePatternProject.UserCards
{
    public abstract class UserCardTemplate
    {
        protected AppUser AppUser { get; set; }

        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }

        public string Build()
        {
            if (AppUser == null) throw new ArgumentNullException(nameof(AppUser));

            StringBuilder sb = new StringBuilder();

            sb.Append("<div class='card'>");
            sb.Append(SetPicture());
            sb.Append($@"<div class='card-body'>
                <h5>{AppUser.UserName}</h5>
                <p>{AppUser.Description}</p>
            ");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");

            return sb.ToString();
        }

        protected abstract string SetFooter();

        protected abstract string SetPicture();
    }
}