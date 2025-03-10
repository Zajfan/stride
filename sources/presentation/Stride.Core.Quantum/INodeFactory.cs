// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core.Reflection;

namespace Stride.Core.Quantum;

/// <summary>
/// This interface represents a factory capable of creating <see cref="IGraphNode"/> instances.
/// </summary>
public interface INodeFactory
{
    /// <summary>
    /// Creates an <see cref="IGraphNode"/> instance that represents a class object.
    /// </summary>
    /// <param name="nodeBuilder">The node builder.</param>
    /// <param name="guid">The unique identifier of the node to build.</param>
    /// <param name="obj">The object represented by the <see cref="IGraphNode"/> instance to create.</param>
    /// <param name="descriptor">The <see cref="ITypeDescriptor"/> of the object represented by the <see cref="IGraphNode"/> instance to create.</param>
    /// <returns>A new <see cref="IGraphNode"/> instance representing the given class object.</returns>
    IObjectNode CreateObjectNode(INodeBuilder nodeBuilder, Guid guid, object obj, ITypeDescriptor descriptor);

    /// <summary>
    /// Creates an <see cref="IGraphNode"/> instance that represents a boxed structure object.
    /// </summary>
    /// <param name="nodeBuilder">The node builder.</param>
    /// <param name="guid">The unique identifier of the node to build.</param>
    /// <param name="structure">The boxed structure object represented bu the <see cref="IGraphNode"/> instace to create.</param>
    /// <param name="descriptor">The <see cref="ITypeDescriptor"/> of the structure represented by the <see cref="IGraphNode"/> instance to create.</param>
    /// <returns>A new <see cref="IGraphNode"/> instance representing the given boxed structure object.</returns>
    IObjectNode CreateBoxedNode(INodeBuilder nodeBuilder, Guid guid, object structure, ITypeDescriptor descriptor);

    /// <summary>
    /// Creates an <see cref="IGraphNode"/> instance that represents a member property of a parent object.
    /// </summary>
    /// <param name="nodeBuilder">The node builder.</param>
    /// <param name="guid">The unique identifier of the node to build.</param>
    /// <param name="parent">The node representing the parent container.</param>
    /// <param name="member">The <see cref="IMemberDescriptor"/> of the member.</param>
    /// <param name="value">The value of this object.</param>
    /// <returns>A new <see cref="IGraphNode"/> instance representing the given member property.</returns>
    IMemberNode CreateMemberNode(INodeBuilder nodeBuilder, Guid guid, IObjectNode parent, IMemberDescriptor member, object? value);
}
