﻿namespace Sharpdev.SDK.Domain
{
    /// <summary>
    ///     Bounded  Context  —  это  реализация  принципа  слабой  связанности  на  более  высоком
    ///     уровне  —  на  уровне подсистемы (модуля). Такая сегментация позволит  вам  более гибко
    ///     управлять  разработкой, вплоть до исключения или переписывания  с  нуля  целых модулей,
    ///     возможно, что даже с полной заменой команды  и/или технологического стека модуля.  Если
    ///     вы игнорируете Bounded Context и расширяете  и  расширяете вашу модель домена, рано или
    ///     поздно  это  закончится тем,  что  стоимость (как по времени,  так и по деньгам) любого
    ///     изменения системы будет стремиться к бесконечности.
    /// </summary>
    public interface IBoundedContext
    {
    }
}
