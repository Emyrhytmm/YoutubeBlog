﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.DTOS.Categories;

namespace YoutubeBlog.Entity.DTOS.Articles
{
	public class ArticleAddDto
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public Guid CategoryId { get; set; }

		public IList<CategoryDto> Categories { get; set; }
	}
}
