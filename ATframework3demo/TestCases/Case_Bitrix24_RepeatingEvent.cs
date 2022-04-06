using atFrameWork2.BaseFramework;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_RepeatingEvent : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание повторяющегося события календаря", homePage => EventRepeatability(homePage)));
            return caseCollection;
        }

        void EventRepeatability(atFrameWork2.PageObjects.PortalHomePage homePage) 
        {
            string newEventName = " для автотеста";
            homePage
                //перейти в календарь
                .LeftMenu
                .OpenCalendar()
                //нажать "добавить"
                .AddEvent()
                //ввести название событие 'новое событие для автотеста'
                .NameNewEvent(newEventName)
                //клик в повторяемость и в выпадающем списке выбрать "каждый день"
                .SetEventRepeat()
                //сохранить
                .Save()
                //нажать на созданное событие
                .OpenCreatedEvent(newEventName)
                //проверить повторяемость (графа повтор в мини-окне события)
                .IsEventRepeating();
        }  
    }
}
