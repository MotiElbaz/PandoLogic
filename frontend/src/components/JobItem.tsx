import { Job } from "../entities/Job";

interface IJobComponent {
  job: Job;
}

const JobItem = ({job} : IJobComponent) => { 
  return (
    <li>{`${job.jobTitleName} in ${job.city}, ${job.state}`}</li>
  );
}

export default JobItem;
