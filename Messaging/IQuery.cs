using MediatR;

namespace DocumentManagment.Utils.Application.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>;
