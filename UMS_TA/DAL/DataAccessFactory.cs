using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Student, int, bool> StudentData()
        {
            return new StudentRepo();
        }


        public static IRepo<PaperPublishList, int, bool> PaperPublishListData()
        {
            return new PaperPublishListRepo();
        }

        public static IRepo<FeedandSurvery, int, bool> FeedandSurveryData()
        {
            return new FeedandSurveyRepo();
        }

        public static IRepo<ConvocationRequest, int, bool> ConvocationRequestData()
        {
            return new ConvocationRequestRepo();
        }

        public static IRepo<CertificationTable, int, bool> CertificationTableData()
        {
            return new CertificationRepo();
        }

        public static IRepo<ApplyThesis, int, bool> ApplyThesisData()
        {
            return new ApplyThesisRepo();
        }
        public static IRepo<AddRequestPaperPublish, int, bool> AddRequestPaperPublishData()
        {
            return new AddRequestPaperPublishRepo();
        }
    }
}
