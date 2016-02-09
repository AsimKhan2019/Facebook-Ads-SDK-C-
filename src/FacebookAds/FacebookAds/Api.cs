﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facebook;

/// <summary>
/// The MIT License (MIT)
///
/// Copyright (c) 2016 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// </summary>
namespace Searchresult.FacebookAds
{
    public class Api
    {
        /// <summary>
        /// The client
        /// </summary>
        protected FacebookClient client;

        /// <summary>
        /// The session
        /// </summary>
        private Session session;

        /// <summary>
        /// Initializes a new instance of the <see cref="Api" /> class.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="session">The session.</param>
        public Api(FacebookClient client, Session session)
        {
            this.client = client;
            this.session = session;
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public FacebookClient Client
        {
            get
            {
                return client;
            }
        }

        /// <summary>
        /// Gets the session.
        /// </summary>
        /// <value>
        /// The session.
        /// </value>
        public Session Session
        {
            get
            {
                return session;
            }
        }


        /// <summary>
        /// The instance
        /// </summary>
        protected static Api instance;

        /// <summary>
        /// Gets or sets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Api Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        /// <summary>
        /// Initializes the specified application identifier.
        /// </summary>
        /// <param name="appId">The application identifier.</param>
        /// <param name="appSecret">The application secret.</param>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The initialized instance of Api</returns>
        public static Api init(string appId, string appSecret, string accessToken)
        {
            Session session = new Session(appId, appSecret, accessToken);
            Api instance = new Api(new FacebookClient(accessToken), session);
            Instance = instance;
            return instance;
        }
    }
}
