﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Thinktecture.Runtime.InteropServices
{
	/// <summary>
	/// Represents a wrapper class for handle resources.
	/// </summary>
	public interface ICriticalHandle : IAbstraction, IDisposable
	{
		/// <summary>
		/// Gets inner instance of <see cref="CriticalHandle"/>.
		/// It is not intended to be used directly. Use <see cref="CriticalHandleExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new CriticalHandle UnsafeConvert();

		/// <summary>Gets a value indicating whether the handle is closed.</summary>
		/// <returns>true if the handle is closed; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		bool IsClosed { get; }

		/// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary>
		/// <returns>true if the handle is valid; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		bool IsInvalid { get; }

		/// <summary>Marks a handle as invalid.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		void SetHandleAsInvalid();
	}
}