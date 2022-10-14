using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;

namespace Application;

public class BoxService : IBoxService
{
    private IBoxRepository _repository;
    private IMapper _mapper;
    private IValidator<PostBoxDTO> _postBoxValidator;
    private IValidator<PutBoxDTO> _putBoxValidator;
    public BoxService(IBoxRepository repository, 
        IMapper mapper,
        IValidator<PostBoxDTO> postBoxValidator,
        IValidator<PutBoxDTO> putBoxValidator)
    {
        _repository = repository;
        _mapper = mapper;
        _postBoxValidator = postBoxValidator;
        _putBoxValidator = putBoxValidator;
    }

    public Box CreateBox(PostBoxDTO box)
    {
        var validate = _postBoxValidator.Validate(box);
        if (!validate.IsValid) throw new ValidationException(validate.Errors.ToString());
        return _repository.CreateBox(_mapper.Map<Box>(box));
    }

    public List<Box> GetAllBoxes()
    {
        return _repository.GetAllBoxes();
    }

    public Box GetBox(int id)
    {
        return _repository.GetBox(id);
    }

    public Box UpdateBox(PutBoxDTO box, int id)
    {
        if (id != box.Id) throw new ValidationException("ID in the body and route are different");
        var validate = _putBoxValidator.Validate(box);
        if (!validate.IsValid) throw new ValidationException(validate.Errors.ToString());
        return _repository.UpdateBox(_mapper.Map<Box>(box), id);
    }

    public Box DeleteBox(int id)
    {
        return _repository.DeleteBox(id);
    }

    public void RebuildDb()
    {
        _repository.RebuildDb();
    }
}