#if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IPAddressInformationCollection"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class IPAddressInformationCollectionExtensions
	{
		/// <summary>
		/// Converts provided collection to <see cref="IIPAddressInformationCollection"/>.
		/// </summary>
		/// <param name="collection">Collection to convert.</param>
		/// <returns>Converted collection.</returns>
		[CanBeNull]
		public static IIPAddressInformationCollection ToInterface([CanBeNull] this IPAddressInformationCollection collection)
		{
			return (collection == null) ? null : new IPAddressInformationCollectionAdapter(collection);
		}
	}
}

#endif
