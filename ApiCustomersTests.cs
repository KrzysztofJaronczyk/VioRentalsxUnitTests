using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VioRentals.Models;

namespace xUnitTests
{
    public class ApiCustomersTests
    {

        //[Fact]
        //public async Task GetCustomers()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers");
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    var customers = JsonConvert.DeserializeObject<List<Customer>>(responseString);
        //    Assert.Equal(3, customers.Count);
        //}

        //[Fact]
        //public async Task GetCustomer()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/1");
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    var customer = JsonConvert.DeserializeObject<Customer>(responseString);
        //    Assert.Equal("John Smith", customer.Name);
        //}

        //[Fact]
        //public async Task CreateCustomer()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Name = "Test Customer",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PostAsync("https://localhost:44315/api/customers",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    var customerDto = JsonConvert.DeserializeObject<Customer>(responseString);
        //    Assert.Equal("Test Customer", customerDto.Name);
        //}

        //[Fact]
        //public async Task UpdateCustomer()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/1",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    var customerDto = JsonConvert.DeserializeObject<Customer>(responseString);
        //    Assert.Equal("John Smith", customerDto.Name);
        //}

        //[Fact]
        //public async Task DeleteCustomer()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/1");
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    var customer = JsonConvert.DeserializeObject<Customer>(responseString);
        //    Assert.Equal("John Smith", customer.Name);
        //}

        //[Fact]

        //public async Task GetCustomerNotFound()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/10");
        //    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task DeleteCustomerNotFound()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/10");
        //    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task UpdateCustomerNotFound()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 10,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/10",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task CreateCustomerBadRequest()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Name = "Test Customer",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PostAsync("https://localhost:44315/api/customers",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task UpdateCustomerBadRequest()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/1",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}

        //[Fact]
        //public async Task GetCustomerBadRequest()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/abc");
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task DeleteCustomerBadRequest()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/abc");
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task UpdateCustomerBadRequest2()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/abc",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        //}

        //[Fact]
        //public async Task GetCustomerInternalServerError()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/0");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task DeleteCustomerInternalServerError()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/0");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task UpdateCustomerInternalServerError()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 0,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/0",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task CreateCustomerInternalServerError()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 0,
        //        Name = "Test Customer",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PostAsync("https://localhost:44315/api/customers",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task GetCustomerException()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/exception");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task DeleteCustomerException()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/exception");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task UpdateCustomerException()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/exception",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}
        
        //[Fact]
        //public async Task CreateCustomerException()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "Test Customer",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PostAsync("https://localhost:44315/api/customers",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task GetCustomerException2()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/exception2");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task DeleteCustomerException2()
        //{
        //    var client = new HttpClient();
        //    var response = await client.DeleteAsync("https://localhost:44315/api/customers/exception2");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task UpdateCustomerException2()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "John Smith",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PutAsync("https://localhost:44315/api/customers/exception2",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task CreateCustomerException2()
        //{
        //    var client = new HttpClient();
        //    var customer = new Customer
        //    {
        //        Id = 1,
        //        Name = "Test Customer",
        //        IsSubscribedToNewsletter = false,
        //        MembershipTypeId = 1
        //    };
        //    var response = await client.PostAsync("https://localhost:44315/api/customers",
        //        new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json"));
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}

        //[Fact]
        //public async Task GetCustomerException3()
        //{
        //    var client = new HttpClient();
        //    var response = await client.GetAsync("https://localhost:44315/api/customers/exception3");
        //    Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
        //}



    }
}
