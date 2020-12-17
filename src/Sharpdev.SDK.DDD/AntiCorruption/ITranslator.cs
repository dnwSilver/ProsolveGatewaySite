﻿namespace Sharpdev.SDK.AntiCorruption
{
    /// <summary>
    ///     Транслятор осуществляет преобразование объектов из одних представлений в другие.
    /// </summary>
    /// <remarks>
    ///     Фактическое  преобразование  концептуальных объектов  или  данных  -  это совсем другая
    ///     сложная задача,  которую  можно передать отдельному объекту, отчего  обе  задачи станут
    ///     понятнее. Транслятор может быть небольшим объектом, создаваемым  и  инициализируемым по
    ///     необходимости.  Ему  не  нужно  собственное  состояние, и  его  не  надо  распределять,
    ///     поскольку    он    должен   находиться   там   же,    где   и   обслуживаемый(-е)    им
    ///     адаптер(ы) (<see cref="IAdapter" />).
    /// </remarks>
    internal interface ITranslator
    {
    }
}
