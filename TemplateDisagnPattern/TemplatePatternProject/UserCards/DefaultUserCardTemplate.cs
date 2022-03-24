namespace TemplatePatternProject.UserCards
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetPicture()
        {
            return $"<img src='/userpictures/default.png' class='card-img-top'>";
        }
    }
}