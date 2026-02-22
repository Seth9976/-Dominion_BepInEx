using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015C RID: 348
	public sealed class SocketElement : ConfigurationElement
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x00061068 File Offset: 0x0005F268
		// Note: this type is marked as 'beforefieldinit'.
		static SocketElement()
		{
			Il2CppClassPointerStore<SocketElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SocketElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketElement>.NativeClassPtr);
			SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100666279);
			SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100666280);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000610C0 File Offset: 0x0005F2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57666, XrefRangeEnd = 57669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x000610FC File Offset: 0x0005F2FC
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57669, XrefRangeEnd = 57672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0000AF0F File Offset: 0x0000910F
		public SocketElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
