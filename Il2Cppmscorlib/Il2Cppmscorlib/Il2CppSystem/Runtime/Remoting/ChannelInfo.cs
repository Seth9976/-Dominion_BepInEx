using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038A RID: 906
	[Serializable]
	public class ChannelInfo : Object
	{
		// Token: 0x06003B19 RID: 15129 RVA: 0x001176CC File Offset: 0x001158CC
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelInfo()
		{
			Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr);
			ChannelInfo.NativeFieldInfoPtr_channelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, "channelData");
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672042);
			ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672043);
			ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr, 100672044);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0011774C File Offset: 0x0011594C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348739, RefRangeEnd = 348741, XrefRangeStart = 348734, XrefRangeEnd = 348739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00117788 File Offset: 0x00115988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348746, RefRangeEnd = 348748, XrefRangeStart = 348741, XrefRangeEnd = 348746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelInfo(Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x001177D4 File Offset: 0x001159D4
		public unsafe virtual Il2CppReferenceArray<Object> ChannelData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelInfo.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x000163C9 File Offset: 0x000145C9
		public ChannelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x00117814 File Offset: 0x00115A14
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x000163D2 File Offset: 0x000145D2
		public unsafe Il2CppReferenceArray<Object> channelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelInfo.NativeFieldInfoPtr_channelData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeFieldInfoPtr_channelData;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;
	}
}
