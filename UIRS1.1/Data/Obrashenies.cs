namespace UIRS1._1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Obrashenies
    {
        [Key]
        public Guid ID_Obrasheniya { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Фамилия*")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Имя*")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Отчество")]
        public string Surname { get; set; }
       
        [Display(Name = "E-mail*")]
        [Required]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [EmailAddress(ErrorMessage = "Неправильно заполнен E-mail")]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(12)]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Required]
        [StringLength(5000)]
        [Display(Name = "Текст обращения*")]
        [DataType(DataType.MultilineText)]
        public string Texttreatment { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Display(Name = "Время")]
        [DataType(DataType.Time)]
        public TimeSpan? Time { get; set; }

        [Display(Name = "Время ожидания (мин)")]
        [Range(typeof(int), "0", "120")]
        public int? Waiting { get; set; }


        [StringLength(150)]
        [Display(Name = "ФИО водителя")]
        public string FIOdriver { get; set; }

        [StringLength(150)]
        [Display(Name = "ФИО кондуктора")]
        public string FIOconductor { get; set; }

        [StringLength(150)]
        [Display(Name = "ФИО диспетчера")]
        public string FIOdispetcher { get; set; }

        [Display(Name = "Раннее окончание работы")]
        public bool Earlyend { get; set; }

        [Display(Name = "Позднее начало работы")]
        public bool LateBeginning { get; set; }

        [Display(Name = "Большой интервал")]
        public bool BigInterval { get; set; }

        [Display(Name = "Нарушение графика")]
        public bool BreachShedule { get; set; }

        [Display(Name = "Проезд остановки")]
        public bool StopTravel { get; set; }

        [Display(Name = "Нарушение посадки (высадки)")]
        public bool ViolationLanding { get; set; }

        [Display(Name = "Выход на линию без договора")]
        public bool OutputWithoutContract { get; set; }

        [Display(Name = "Нарушение схемы движения")]
        public bool ViolationOfTrafficPatterns { get; set; }

        [Display(Name = "Нарушение ПДД")]
        public bool VioletionOfTrafficRules { get; set; }

        [Display(Name = "Конфликтная ситуация (грубость) с кондуктором")]
        public bool ConflictWithConductor { get; set; }

        [Display(Name = "Конфликтная ситуация (грубость) с водителем")]
        public bool ConflictWithDriver { get; set; }

        [Display(Name = "Неправильно сдали сдачу")]
        public bool WrongSurrendere { get; set; }

        [Display(Name = "Не объявление остановки")]
        public bool NotAnnouncedBusstop { get; set; }

        [Display(Name = "Курение в салоне")]
        public bool SmokingInCabin { get; set; }

        [Display(Name = "Разговоры по телефону")]
        public bool DiscussionOnPhone { get; set; }

        [Display(Name = "Громкая музыка")]
        public bool LoudMusic { get; set; }

        [Display(Name = "Отсутствие билето")]
        public bool LackOfTickets { get; set; }

        [Display(Name = "Неисправен автобус")]
        public bool FaultyBus { get; set; }

        [Display(Name = "Запах газа")]
        public bool SmellOfGus { get; set; }

        [Display(Name = "Плохое санитарное состояние")]
        public bool PoorSanCondition { get; set; }

        [Display(Name = "Работа табло")]
        public bool WorkBoards { get; set; }

        [Display(Name = "Работа сайта")]
        public bool WorkSite { get; set; }

        [Display(Name = "Работа СМС-сервиса")]
        public bool WorkSmsService { get; set; }

        [Display(Name = "Работа онлайн-карты")]
        public bool WorkOnlineMap { get; set; }

        [Display(Name = "Работа веб-табло")]
        public bool WorkWebBoards { get; set; }

        [Display(Name = "Работа мобильного приложения")]
        public bool WorkMobileApplication { get; set; }

        [Display(Name = "Плохое состояние отстойно-разворотной площадки")]
        public bool PoorStateReversalArea { get; set; }

        [Display(Name = "Плохое состояние остановки")]
        public bool PoorStateBusstop { get; set; }

        [Display(Name = "Неудобство инфраструктуры")]
        public bool DisadvantageOfInfrastructures { get; set; }

        [Display(Name = "Конфликтная ситуация (грубость) с диспетчером")]
        public bool ConflictWithDispather { get; set; }

        [Display(Name = "Соблюдение расписания")]
        public bool ComplianceWithShedule { get; set; }

        [Display(Name = "Хорошее качество обслуживания")]
        public bool GoodQualityService { get; set; }

        [Display(Name = "Вежливый персонал")]
        public bool CourteousStaff { get; set; }

        [Display(Name = "Хорошее состояние транспорта")]
        public bool GoodTransportCondition { get; set; }

        [Display(Name = "Маршрут (номер и тип)")]
        public Guid? ID_Route { get; set; }

        [Display(Name = "Транспортное средство (гос. номер)")]
        public Guid? ID_Vehicle { get; set; }

        [Display(Name = "Остановка")]
        public Guid? ID_Point { get; set; }

        public int ID_status { get; set; }

        public virtual POINT POINT { get; set; }

        public virtual ROUTE ROUTE { get; set; }

        public virtual VEHICLE VEHICLE { get; set; }

        public virtual StatusObrasheniya StatusObrasheniya { get; set; }
    }
}
