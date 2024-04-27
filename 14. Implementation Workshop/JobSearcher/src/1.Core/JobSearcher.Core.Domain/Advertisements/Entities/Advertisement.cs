using Zamin.Core.Domain.Entities;
using JobSearcher.Core.Domain.Advertisements.Entities;
using JobSearcher.Core.Domain.Advertisements.Parameters;
using JobSearcher.Core.Domain.Advertisements.Events;
using JobSearcher.Core.Resources;

namespace JobSearcher.Core.Domain.Advertisemetns.Entities;

public sealed class Advertisement : AggregateRoot<int>
{
    #region Properties
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int CityId { get; private set; }
    public int Salary { get; private set; }
    public bool IsRemote { get; private set; }
    public DateTime? PublisheDate { get; private set; }

    private List<Course> _courses;

    public IReadOnlyCollection<Course> Courses => _courses;


    #endregion

    #region Constructors
    private Advertisement()
    {

    }
    public Advertisement(AdvertisementCreateParameter parameter)
    {
        Title = parameter.Title;
        Description = parameter.Description;
        CityId = parameter.CityId;
        Salary = parameter.Salary;
        IsRemote = parameter.IsRemote;
        AddEvent(new AdvertisementCreated(BusinessId.Value, Title, Description, Salary, CityId, IsRemote));
    }
    #endregion

    #region Commands
    public void Update(AdvertisementUpdateParameter parameter)
    {
        Title = parameter.Title;
        Description = parameter.Description;
        CityId = parameter.CityId;
        Salary = parameter.Salary;
        IsRemote = parameter.IsRemote;
        AddEvent(new AdvertisementUpdated(Id, BusinessId.Value, Title, Description, Salary, CityId, IsRemote));
    }

    public void Delete()
    {
        AddEvent(new AdvertisementDeleted(BusinessId.Value, Id));
    }

    public void Publish()
    {
        if (PublisheDate.HasValue)
        {
            throw new Zamin.Core.Domain.Exceptions.InvalidEntityStateException(ProjectValidationError.VALIDATION_ERROR_NOT_VALID, nameof(PublisheDate));
        }
        PublisheDate = DateTime.Now;
        AddEvent(new AdvertisementPublished(BusinessId.Value, Id, PublisheDate.Value));
    }

    public void Unpublish()
    {
        if (!PublisheDate.HasValue)
        {
            throw new Zamin.Core.Domain.Exceptions.InvalidEntityStateException(ProjectValidationError.VALIDATION_ERROR_NOT_VALID, nameof(PublisheDate));
        }
        PublisheDate = null;
        AddEvent(new AdvertisementUnPublished(BusinessId.Value, Id));
    }
    #endregion
}