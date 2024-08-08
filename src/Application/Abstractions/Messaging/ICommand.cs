﻿using MediatR;

namespace SupplierService.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>;