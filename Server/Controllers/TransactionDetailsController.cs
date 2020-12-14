using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DantunkuraGallery.Server.Models;

namespace DantunkuraGallery.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailsController : ControllerBase
    {
        private readonly POS_DBContext _context;

        public TransactionDetailsController(POS_DBContext context)
        {
            _context = context;
        }

        // GET: api/TransactionDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDetail>>> GetTransactionDetails()
        {
            return await _context.TransactionDetails.ToListAsync();
        }

        // GET: api/TransactionDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionDetail>> GetTransactionDetail(int id)
        {
            var transactionDetail = await _context.TransactionDetails.FindAsync(id);

            if (transactionDetail == null)
            {
                return NotFound();
            }

            return transactionDetail;
        }

        // PUT: api/TransactionDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionDetail(int id, TransactionDetail transactionDetail)
        {
            if (id != transactionDetail.TdetailsNo)
            {
                return BadRequest();
            }

            _context.Entry(transactionDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TransactionDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransactionDetail>> PostTransactionDetail(TransactionDetail transactionDetail)
        {
            _context.TransactionDetails.Add(transactionDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransactionDetail", new { id = transactionDetail.TdetailsNo }, transactionDetail);
        }

        // DELETE: api/TransactionDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionDetail(int id)
        {
            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            _context.TransactionDetails.Remove(transactionDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransactionDetailExists(int id)
        {
            return _context.TransactionDetails.Any(e => e.TdetailsNo == id);
        }
    }
}
