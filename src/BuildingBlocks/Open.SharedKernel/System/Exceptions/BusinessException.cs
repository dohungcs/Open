﻿using Microsoft.Extensions.Logging;

namespace Open.SharedKernel.System.Exceptions;

public abstract class BusinessException(
    string? code = null, 
    string? message = null,
    string? details = null,
    Exception? innerException = null, 
    LogLevel logLevel = LogLevel.Warning) 
    : Exception(message, innerException) , IBusinessException
{
    public string? Code { get; set; } = code;

    public string? Details { get; set; } = details;

    public LogLevel LogLevel { get; set; } = logLevel;

    public BusinessException WithData(string name, object value)
    {
        Data[name] = value;
        return this;
    }
}
