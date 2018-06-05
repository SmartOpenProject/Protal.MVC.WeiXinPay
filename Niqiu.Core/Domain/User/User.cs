﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Niqiu.Core.Domain.Common;
using Niqiu.Core.Domain.IM;

namespace Niqiu.Core.Domain.User
{
    [Serializable]
    public class User : BaseEntity
    {
        private ICollection<Address> _addresses;
        private ICollection<UserRole> _userRoles;
        private ICollection<Group> _groups;

        public User()
        {
            UserGuid = Guid.NewGuid();
            LastActivityDateUtc = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the customer Guid
        /// </summary>
        public Guid UserGuid { get; set; }

        [Display(Name = "性别")]
        public string Gender { get; set; }

        [Display(Name = "学号")]
        public string SchoolNumber { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        public string Mobile { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the password format
        /// </summary>
        public int PasswordFormatId { get; set; }
       
        /// <summary>
        /// Gets or sets the password salt
        /// </summary>
        public string PasswordSalt { get; set; }


        public string RealName { get; set; }

        public string IDCard { get; set; }

        //学院名称
        public string SchoolName { get; set; }

        public string Description { get; set; }


        public string ImgUrl { get; set; }
        
        public string OpenId { get; set; }

        public string Province { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public PasswordFormat PasswordFormat
        {
            get { return (PasswordFormat)PasswordFormatId; }
            set { PasswordFormatId = (int)value; }
        }

        /// <summary>
        /// Gets or sets the vendor identifier with which this customer is associated (maganer)
        /// </summary>
        //public int VendorId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer is active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer has been deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer account is system
        /// </summary>
        public bool IsSystemAccount { get; set; }


        /// <summary>
        /// Gets or sets the customer system name
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Gets or sets the last IP address
        /// </summary>
        public string LastIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last login
        /// </summary>
        public DateTime? LastLoginDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of last activity
        /// </summary>
        public DateTime LastActivityDateUtc { get; set; }

        /// <summary>
        /// Gets or sets customer addresses
        /// </summary>
        public virtual ICollection<Address> Addresses
        {
            get { return _addresses ?? (_addresses = new Collection<Address>()); }
            protected set { _addresses = value; }
        }

        ///// <summary>
        ///// Gets or sets the customer roles
        ///// </summary>
        public virtual ICollection<UserRole> UserRoles
        {
            get { return _userRoles ?? (_userRoles = new Collection<UserRole>()); }
            protected set { _userRoles = value; }
        }

        /// <summary>
        /// 一个用户所拥有的群
        /// </summary>
        public virtual ICollection<Group> Groups
        {
            get { return _groups??(_groups=new Collection<Group>()); }
            set { _groups = value; }
        }
    }
}
