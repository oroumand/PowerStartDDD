using Microsoft.AspNetCore.Mvc;
using Zamin.Core.RequestResponse.Queries;
using Zamin.EndPoints.Web.Controllers;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Create;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Delete;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Update;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetById;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetPagedFilter;
using JobSearcher.Core.RequestResponse.Advertisements.Queries.GetSelectList;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.Publishe;
using JobSearcher.Core.RequestResponse.Advertisements.Commands.UnPublishe;

namespace JobSearcher.Endpoints.API.Advertisements;

[Route("api/[controller]")]

public sealed class AdvertisementController : BaseController
{
    #region Commands
    [HttpPost("Create")]
    public async Task<IActionResult> CreateAdvertisement([FromBody] AdvertisementCreateCommand command)
        => await Create<AdvertisementCreateCommand, int>(command);

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateAdvertisement([FromBody] AdvertisementUpdateCommand command)
        => await Edit(command);

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteAdvertisement([FromBody] AdvertisementDeleteCommand command)
        => await Delete(command);

    [HttpPut("Publishe")]
    public async Task<IActionResult> PublisheAdvertisement([FromBody] AdvertisementPublisheCommand command)
    => await Edit(command);


    [HttpPut("UnPublishe")]
    public async Task<IActionResult> UnPublisheAdvertisement([FromBody] AdvertisementUnPublisheCommand command)
=> await Edit(command);
    #endregion

    #region Queries
    [HttpGet("GetById")]
    public async Task<IActionResult> GetAdvertisementById([FromQuery] AdvertisementGetByIdQuery query)
        => await Query<AdvertisementGetByIdQuery, AdvertisementQr?>(query);

    [HttpGet("GetSelectList")]
    public async Task<IActionResult> GetAdvertisementSelectList([FromQuery] AdvertisementGetSelectListQuery query)
        => await Query<AdvertisementGetSelectListQuery, List<AdvertisementSelectItemQr>>(query);

    [HttpGet("GetPagedFilter")]
    public async Task<IActionResult> GetAdvertisementPagedFilter([FromQuery] AdvertisementGetPagedFilterQuery query)
        => await Query<AdvertisementGetPagedFilterQuery, PagedData<AdvertisementListItemQr>>(query);
    #endregion
}