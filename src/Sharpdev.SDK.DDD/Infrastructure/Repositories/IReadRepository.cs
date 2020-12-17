using System.Collections.Generic;
using System.Threading.Tasks;

using Sharpdev.SDK.Domain;
using Sharpdev.SDK.Domain.Entities;
using Sharpdev.SDK.Domain.Specifications;

namespace Sharpdev.SDK.Infrastructure.Repositories
{
    /// <summary>
    ///     Репозиторий позволяет абстрагироваться от конкретных подключений к источникам данных, с
    ///     которыми  работает  программа,   и   является  промежуточным  звеном  между   классами,
    ///     непосредственно взаимодействующими с данными, и остальной программой.
    ///     Данный репозиторий предназначен только для чтения агрегатов.
    /// </summary>
    /// <typeparam name="TAggregate"> Основная сущность для общения с источником данных. </typeparam>
    public interface IReadRepository<TAggregate>
            where TAggregate: IAggregate<TAggregate>, IEntity<TAggregate>
    {
        /// <summary>
        ///     Поиск и получение необходимых бизнес объектов в источнике данных.
        /// </summary>
        /// <param name="specification"> Набор параметров для поиска. </param>
        /// <returns> Набор бизнес объектов. </returns>
        Task<IEnumerable<TAggregate>> ReadAsync(ISpecification<TAggregate> specification);
    }
}
