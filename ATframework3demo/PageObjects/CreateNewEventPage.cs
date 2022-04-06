using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects
{
    public class CreateNewEventPage
    {
        internal CreateNewEventPage SetEventRepeat()
        {
            //клик в выпадающем списке в "каждый день"
            var repeatingSelector = new WebItem("//select[@name='EVENT_RRULE[FREQ]']", "Селектор повторяемости события");
            repeatingSelector.SelectListItemByText("Каждый день");
            return new CreateNewEventPage();
        }

        internal CalendarMainPage Save()
        {
            //нажать "сохранить", после чего будет переход на страницу календаря
            var createEvent = new WebItem("//button[contains(text(), 'Сохранить')]", "Кнопка Сохранить событие");
            createEvent.Click();
            return new CalendarMainPage();
        }


        internal CreateNewEventPage NameNewEvent(string newEventName)
        {
            var giveNameToNewEvent = new WebItem("//input[@name='name']", "Дадим название событию");
            giveNameToNewEvent.Click();
            giveNameToNewEvent.SendKeys(newEventName);
            return new CreateNewEventPage();
        }
    }
}
