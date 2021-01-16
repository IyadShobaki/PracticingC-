using System;
using System.Collections.Generic;

namespace InterfacesAndPolymorphismMosh
{
    public interface IWorkflowActivity
    {
        void Execute();
    }
    public interface IWorkflow
    {
        void Add(IWorkflowActivity activity);
        void Remove(IWorkflowActivity activity);
        IEnumerable<IWorkflowActivity> GetWorkflowActivities();
    }
    public class Workflow : IWorkflow
    {
        private readonly IList<IWorkflowActivity> _workflowActivities;
        public Workflow()
        {
            _workflowActivities = new List<IWorkflowActivity>();
        }
        public void Add(IWorkflowActivity activity)
        {
            _workflowActivities.Add(activity);
        }

        public void Remove(IWorkflowActivity activity)
        {
            _workflowActivities.Remove(activity);
        }

        public IEnumerable<IWorkflowActivity> GetWorkflowActivities()
        {
            return _workflowActivities;
        }
    }

    public class UploadVideo : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
    public class CallWebService : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party.....");
        }
    }

    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {

            foreach (var activity in workflow.GetWorkflowActivities())
            {
                activity.Execute();
            }
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            //VideoEncoder encoder = new VideoEncoder();
            //encoder.RegisterNotificationChannel(new MailNotificationChannel());
            //encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            //encoder.Encode(new Video());

            Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new CallWebService());

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);


            Console.ReadLine();
        }
    }
}
