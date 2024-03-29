﻿namespace Sharpdev.SDK.AntiCorruption
{
    /// <summary>
    ///     Адаптер для внешней системы.
    /// </summary>
    /// <remarks>
    ///     АДАПТЕР (ADAPTER) представляет собой объект-оболочку,  позволяющую клиенту пользоваться
    ///     не тем ПРОТОКОЛОМ, который понятен реализатору операции,  а каким-нибудь другим.  Когда
    ///     клиент  посылает  сообщение АДАПТЕРУ,  оно преобразуется  в  семантически эквивалентное
    ///     сообщение и пересылается "адаптанту".  Ответ оттуда опять  преобразуется и пересылается
    ///     назад.
    /// </remarks>
    public interface IAdapter
    {
    }
}
