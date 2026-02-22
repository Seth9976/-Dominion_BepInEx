using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035C RID: 860
	public sealed class BinaryCrossAppDomainString : Object
	{
		// Token: 0x060036D9 RID: 14041 RVA: 0x00109998 File Offset: 0x00107B98
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainString()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr);
			BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "objectId");
			BinaryCrossAppDomainString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "value");
			BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671707);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671708);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671709);
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00109A2C File Offset: 0x00107C2C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00109A68 File Offset: 0x00107C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344976, RefRangeEnd = 344979, XrefRangeStart = 344976, XrefRangeEnd = 344979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00109AAC File Offset: 0x00107CAC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public BinaryCrossAppDomainString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x00109AE0 File Offset: 0x00107CE0
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x00013CC9 File Offset: 0x00011EC9
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x00109B08 File Offset: 0x00107D08
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00013CE4 File Offset: 0x00011EE4
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
