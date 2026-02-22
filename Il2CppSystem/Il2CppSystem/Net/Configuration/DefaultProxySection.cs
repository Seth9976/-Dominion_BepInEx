using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000154 RID: 340
	public sealed class DefaultProxySection : ConfigurationSection
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x00060A08 File Offset: 0x0005EC08
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultProxySection()
		{
			Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr);
			DefaultProxySection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100666263);
			DefaultProxySection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100666264);
			DefaultProxySection.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr, 100666265);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00060A74 File Offset: 0x0005EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57618, XrefRangeEnd = 57621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultProxySection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00060AB0 File Offset: 0x0005ECB0
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57621, XrefRangeEnd = 57624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00060AF0 File Offset: 0x0005ECF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57624, XrefRangeEnd = 57627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset(ConfigurationElement parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySection.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0000AE8E File Offset: 0x0000908E
		public DefaultProxySection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_ConfigurationElement_0;
	}
}
