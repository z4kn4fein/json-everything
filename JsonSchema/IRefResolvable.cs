﻿using System;

namespace Json.Schema;

/// <summary>
/// Defines functionality required to resolve `$ref` and `$recursiveRef` keywords.
/// </summary>
/// <remarks>
/// Should be implemented for any keyword that contains navigable data.
/// </remarks>
public interface IRefResolvable
{
	/// <summary>
	/// Passes registration of any subschemas back to <see cref="JsonSchema.RegisterSubschemas(SchemaRegistry,Uri)"/>.
	/// </summary>
	/// <param name="registry">The registry into which the subschema should be registered.</param>
	/// <param name="currentUri">The current URI.</param>
	/// <remarks>
	/// Just call <see cref="JsonSchema.RegisterSubschemas(SchemaRegistry,Uri)"/> on each schema
	/// contained within the keyword.  
	/// </remarks>
	void RegisterSubschemas(SchemaRegistry registry, Uri currentUri);
}