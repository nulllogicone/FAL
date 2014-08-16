namespace FAL.Annotation.DAL
{
    using System.Configuration;
    using System;

    public partial class AnnotationDataContext
    {
        /// <summary>
        /// Diesen Konstruktor *NICHT LÖSCHEN*
        /// Wenn er doppelt vorkommt, dann den Konstruktor in der Designerdatei löschen.
        /// </summary>
        public AnnotationDataContext() :
            base(ConfigurationManager.ConnectionStrings["LotboxConnectionString"].ConnectionString)
        {
            OnCreated();
        }

        // Annotation
        // ----------

        partial void InsertAnnotation(Annotation instance)
        {
            instance.AnnotationGuid = Guid.NewGuid();
            instance.Datum = DateTime.Now;

            if (instance.IconUrl == null) instance.IconUrl = "";
            if (instance.Type == null) instance.Type = "";
            if (instance.Status == null) instance.Status = "";
            //if (instance.Priority == null) instance.Priority = 0;

            this.ExecuteDynamicInsert(instance);
        }

        partial void UpdateAnnotation(Annotation instance)
        {
            if (instance.IconUrl == null) instance.IconUrl = "";
            if (instance.Type == null) instance.Type = "";
            if (instance.Status == null) instance.Status = "";
            //if (instance.Priority == null) instance.Priority = 0;

            this.ExecuteDynamicUpdate(instance);
        }
    }

    public partial class Annotation
    {
        public override string ToString()
        {
            string s = string.Format("Titel: {0} \r\n Text:{1}", this.Titel, this.Text);
            return s;
        }
    }
}
