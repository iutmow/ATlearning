using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects
{
    public class CalendarMainPage
    {
        internal CreateNewEventPage AddEvent()
        {
            //клик в "Добавить"
            var addButton = new WebItem("//span[@data-role='addButton']", "Кнопка Добавить событие");
            addButton.Click();
            return new CreateNewEventPage();
        }

        internal CreatedEventMiniPage OpenCreatedEvent(string newEventName)
        {
            //клик в созданное событие
            var createdEvent = new WebItem($"//span[contains(text(), '{newEventName}')]", "Название созданного события");
            createdEvent.Click();
            return new CreatedEventMiniPage();
        }
    }
}
