using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000348 RID: 840
	public class Subscription : Object
	{
		// Token: 0x060032CA RID: 13002 RVA: 0x000D3F70 File Offset: 0x000D2170
		// Note: this type is marked as 'beforefieldinit'.
		static Subscription()
		{
			Il2CppClassPointerStore<Subscription>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Subscription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subscription>.NativeClassPtr);
			Subscription.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscription>.NativeClassPtr, "dataType");
			Subscription.NativeMethodInfoPtr__ctor_Public_Void_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscription>.NativeClassPtr, 100669808);
			Subscription.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscription>.NativeClassPtr, 100669809);
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000D3FDC File Offset: 0x000D21DC
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Subscription(DataType dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subscription>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscription.NativeMethodInfoPtr__ctor_Public_Void_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000D4028 File Offset: 0x000D2228
		public unsafe DataType DataType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscription.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00013C0A File Offset: 0x00011E0A
		public Subscription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x000D4068 File Offset: 0x000D2268
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00013C13 File Offset: 0x00011E13
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscription.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscription.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataType_0;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;
	}
}
