﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.TeacherSocialDtos
{
    public class CreateTeacherSocialDto
    {
        public string Url { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public int TeacherId { get; set; }
    }
}