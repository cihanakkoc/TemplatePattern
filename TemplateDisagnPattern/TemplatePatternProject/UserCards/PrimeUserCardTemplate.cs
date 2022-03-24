using System.Text;

namespace TemplatePatternProject.UserCards
{
    public class PrimeUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<a href='#' class='btn btn-primary'>Mesaj Gönder</a>");
            sb.Append("<a href='#' class='btn btn-primary'>Detaylı Profil</a>");

            return sb.ToString();
        }

        protected override string SetPicture()
        {
            return $"<img src='/userpictures/{AppUser.PictureUrl}' class='card-img-top'>";
        }
    }
}