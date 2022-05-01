export class JobService {
  readonly API_URL: string = 'https://localhost:5001/api/jobtitles';

  public getJobTitles = async () => {
    return this.getRequest(this.API_URL);
  };

  public getJobsForJobTitle = async (jobTitleId: number) => {
    return this.getRequest(`${this.API_URL}/${jobTitleId}/jobs`);
  };

  public getRequest = async (url: string) => {
    try {
      const response = await fetch(url);
      if (!response.ok) {
        throw response.statusText;
      }
      return await response.json();
    } catch (e) {
      console.error(e);
      return [];
    }
  };
}