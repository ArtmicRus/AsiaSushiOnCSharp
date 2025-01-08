using AsiaSushiOnCSharp.Domain.Entity.Base;
using AsiaSushiOnCSharp.Domain.Enums;

namespace AsiaSushiOnCSharp.Domain.Entity.Feedback
{
    internal class Review : BaseEntity
    {
        public Review() 
        {
            PublicationDate = DateTime.Now;
        }

        /// <summary>
        /// Заголовок отзыва
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Текст отзыва
        /// </summary>
        public required string Comment { get; set; }

        /// <summary>
        /// Ответ модерации/администрации
        /// </summary>
        public string Answer { get; set; } = string.Empty;

        /// <summary>
        /// Оценка к отзыву
        /// </summary>
        public required Scores Score { get; set; }

        /// <summary>
        /// Дата публикации отзыва
        /// </summary>
        public required DateTime PublicationDate { get; set; }
    }
}
