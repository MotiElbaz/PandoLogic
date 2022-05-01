import React, { useEffect, useState } from 'react';
import JobItem from '../components/JobItem';
import List from '../components/List';
import Search from '../components/Search';
import { Job } from '../entities/Job';
import { JobTitle } from '../entities/JobTitle';
import { JobService } from '../services/jobs.service';

const jobService = new JobService();

const JobsPage = () => {

  const [allJobTitles, setAllJobTitles] = useState<JobTitle[]>([]);
  const [allJobs, setAllJobs] = useState<Job[]>([])

  useEffect( () => {
    const getJobTitles = async () => {
      const allJobTitles: JobTitle[] = await jobService.getJobTitles();
      setAllJobTitles(allJobTitles);
    }
    getJobTitles();
  }, []);

  const onSearch = async (id: number) => {
    const allJobs: Job[] = await jobService.getJobsForJobTitle(id);
    setAllJobs(allJobs);
  }

  const options: any[] = allJobTitles.map((jobTitle) => ({
    label: jobTitle.jobTitleName,
    value: jobTitle.jobTitleId,
  }));

  const renderJobItem = (job: Job, index: number) => {
    return (<JobItem job={job} key={index}></JobItem>);
  }

  return (
    <div className="container">
      <Search options={options} onSearch={onSearch} stringLength={2}></Search>
      <List allItems={allJobs} renderFunction={renderJobItem}></List>
    </div>
  );
}

export default JobsPage;
