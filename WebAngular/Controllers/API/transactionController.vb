Imports System.Web.Mvc


End Namespace
Using System;
Using System.Collections.Generic;
Using System.Data;
Using System.Data.Entity;
Using System.Data.Entity.Infrastructure;
Using System.Linq;
Using System.Net;
Using System.Net.Http;
Using System.Web.Http;
Using System.Web.Http.Description;
Using bse161001.Models;

Namespace bse161001.Controllers
{
    Public Class Transactionbse161001Controller :  ApiController
    {
        Private bse161001Entities db = New bse161001Entities();

        // GET api/Transactionbse161001
        Public IQueryable<Transactionbse161001> GetTransactionbse161001()
        {
            Return db.Transactionbse161001;
        }

        // GET api/Transactionbse161001/5
        [ResponseType(TypeOf(Transactionbse161001))]
        Public IHttpActionResult GetTransactionbse161001(int id)
        {
            Transactionbse161001 transactionbse161001 = db.Transactionbse161001.Find(id);
            If (transactionbse161001 == null)
            {
                Return NotFound();
            }

            Return Ok(transactionbse161001);
        }

        // PUT api/Transactionbse161001/5
        [ResponseType(TypeOf(void))]
        Public IHttpActionResult PutTransactionbse161001(int id, Transactionbse161001 transactionbse161001)
        {
            If (!ModelState.IsValid)
            {
                Return BadRequest(ModelState);
            }

            If (id! = transactionbse161001
            .TransactionId)
            {
                Return BadRequest();
            }

            db.Entry(transactionbse161001).State = EntityState.Modified;

            Try
            {
                db.SaveChanges();
            }
            Catch (DbUpdateConcurrencyException)
            {
                If (!Transactionbse161001Exists(id))
                {
                    Return NotFound();
                }
                Else
                {
                    Throw;
                }
            }

            Return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Transactionbse161001
        [ResponseType(TypeOf(Transactionbse161001))]
        Public IHttpActionResult PostTransactionbse161001(Transactionbse161001 transactionbse161001)
        {
            If (!ModelState.IsValid)
            {
                Return BadRequest(ModelState);
            }

            db.Transactionbse161001.Add(transactionbse161001);

            Try
            {
                db.SaveChanges();
            }
            Catch (DbUpdateException)
            {
                If (transactionbse161001
            (transactionbse161001.TransactionId))
                {
                    Return Conflict();
                }
                Else
                {
                    Throw;
                }
            }

            Return CreatedAtRoute("DefaultApi", New { id = transactionbse161001.TransactionId }, transactionbse161001);
        }

        // DELETE api/Transactionbse161001
        [ResponseType(TypeOf(Transactionbse161001))]
        Public IHttpActionResult DeleteTransactionbse161001(int id)
        {
            Transactionbse161001 transactionbse161001 = db.Transactionbse161001.Find(id);
            If (transactionbse161001 == null)
            {
                Return NotFound();
            }

            db.Transactionbse161001.Remove(transactionbse161001);
            db.SaveChanges();

            Return Ok(transactionbse161001);
        }

        Protected override void Dispose(bool disposing)
        {
            If (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        Private bool Transactionbse161001Exists(int id)
        {
            Return db.Transactionbse161001.Count(e >= e.TransactionId == id) > 0;
        }
    }
}