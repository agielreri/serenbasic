﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using MyRepository = SerenBasic.Northwind.Repositories.OrderDetailRepository;
using MyRow = SerenBasic.Northwind.Entities.OrderDetailRow;

namespace SerenBasic.Northwind.Endpoints
{
    [Route("Services/Northwind/OrderDetail/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class OrderDetailController : ServiceEndpoint
    {
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository(Context).Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository(Context).List(connection, request);
        }
    }
}
