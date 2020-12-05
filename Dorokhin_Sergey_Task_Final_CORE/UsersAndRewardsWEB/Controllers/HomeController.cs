using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UsersAndRewardsWEB.Models;
using UsersAndRewards.DAL;
using UsersAndRewards.BLL;
using HelperEntities;

namespace UsersAndRewardsWEB.Controllers
{
    public class HomeController : Controller
    {
        private UsersBL _usersBL = new UsersBL(new UsersSql());
        private RewardsBL _rewardsBL = new RewardsBL(new RewardsSql());
        private Usewards _usewards = new Usewards();

        [HttpGet]
        public IActionResult Index()
        {
            _usewards.UsersList = _usersBL.GetList();
            _usewards.RewardsList = _rewardsBL.GetList();

            return View(_usewards);
        }

        [HttpPost]
        public IActionResult AddReward()
        {
            string rewardTitle = Request.Form["uTitle"];
            string rewardDescription = Request.Form["uDescription"];

            _rewardsBL.Add(new Entites.Reward(0, rewardTitle, rewardDescription));

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateReward()
        {
            int rewardId = int.Parse(Request.Form["uRewardId"]);
            string rewardTitle = Request.Form["uTitle"];
            string rewardDescription = Request.Form["uDescription"];

            _rewardsBL.Update(new Entites.Reward(rewardId, rewardTitle, rewardDescription));

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveReward()
        {
            int rewardIdToRemove = int.Parse(Request.Form["rewardIdToRemove"]);

            _rewardsBL.Remove(new Entites.Reward(rewardIdToRemove, "", ""));

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddUser()
        {
            string userFirstName = Request.Form["uFirstName"];
            string userLastName = Request.Form["uLastName"];
            string userBirthday = Request.Form["uBirthday"];
            string stringWithRewardsNames = Request.Form["selectRewardsUserCreate"];
            string[] userBirthdayParsed = userBirthday.Split(".");
            string[] rewardsNames = stringWithRewardsNames.Split(",");
            var rewardsList = new List<Entites.Reward>();
            
            
            foreach (var reward in _rewardsBL.GetList())
            {
                foreach (var rewardName in rewardsNames)
                {
                    if (rewardName == reward.Title)
                    {
                        rewardsList.Add(reward);
                    }
                }
            }

            _usersBL.Add(new Entites.User(0, 
                                          userFirstName, 
                                          userLastName, 
                                          new DateTime(int.Parse(userBirthdayParsed[2]), 
                                                       int.Parse(userBirthdayParsed[1]),
                                                       int.Parse(userBirthdayParsed[0])),
                                          rewardsList));
            
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult RemoveUser()
        {
            int userIdToRemove = int.Parse(Request.Form["userIdToRemove"]);

            _usersBL.Remove(new Entites.User(userIdToRemove, "", "", DateTime.Now, new List<Entites.Reward>()));
            
            return RedirectToAction("Index");
        }

        public IActionResult UpdateUser()
        {
            int userId = int.Parse(Request.Form["uUserId"]);
            string userFirstName = Request.Form["uFirstName"];
            string userLastName = Request.Form["uLastName"];
            string userBirthday = Request.Form["uBirthday"];
            string[] userBirthdayParsed = userBirthday.Split(".");

            _usersBL.Update(new Entites.User(userId,
                                             userFirstName,
                                             userLastName,
                                             new DateTime(int.Parse(userBirthdayParsed[2]), 
                                                          int.Parse(userBirthdayParsed[1]), 
                                                          int.Parse(userBirthdayParsed[0])),
                                             new List<Entites.Reward>()));

            return RedirectToAction("Index");
        }
    }
}
