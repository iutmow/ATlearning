using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects
{
    public class CreatedEventMiniPage
    {
       
        internal CreatedEventMiniPage IsEventRepeating()
        {
            var eventRepeat = new WebItem("//div[contains(text(), 'ежедневно') or contains(text(), 'каждую неделю') or contains(text(), 'ежемесячно') or contains(text(), 'ежегодно')]", "Значение графы повтора события");
            if (eventRepeat.WaitElementDisplayed(1))
                Log.Info("Созданное событие повторяется");
            else
                Log.Error("Созданное событие не имеет повтора");
            return new CreatedEventMiniPage();
        }  
    }
}
