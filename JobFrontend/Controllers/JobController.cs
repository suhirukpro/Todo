using JobFrontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JobFrontend.Controllers
{
    public class JobController : Controller
    {
        // GET: JobController
        public async Task<ActionResult> IndexAsync()
        {
            List<Job> jobs = new List<Job>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7078/api/Jobs"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    jobs = JsonConvert.DeserializeObject<List<Job>>(apiResponse);
                }
            }
            return View(jobs);
        }

        // GET: JobController/Details/5
        public async Task<ActionResult> DetailsAsync(int id)
        {
            Job job = new Job();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7078/api/Jobs/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    job = JsonConvert.DeserializeObject<Job>(apiResponse);
                }
            }
            return View(job);
        }

        // GET: JobController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
