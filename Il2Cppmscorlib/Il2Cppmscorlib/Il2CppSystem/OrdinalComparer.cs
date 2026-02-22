using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public sealed class OrdinalComparer : StringComparer
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x0006F104 File Offset: 0x0006D304
		// Note: this type is marked as 'beforefieldinit'.
		static OrdinalComparer()
		{
			Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OrdinalComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr);
			OrdinalComparer.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, "_ignoreCase");
			OrdinalComparer.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666150);
			OrdinalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666151);
			OrdinalComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666152);
			OrdinalComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666153);
			OrdinalComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666154);
			OrdinalComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr, 100666155);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0006F1C0 File Offset: 0x0006D3C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298121, RefRangeEnd = 298123, XrefRangeStart = 298117, XrefRangeEnd = 298121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrdinalComparer(bool ignoreCase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrdinalComparer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreCase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0006F208 File Offset: 0x0006D408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298123, XrefRangeEnd = 298125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0006F268 File Offset: 0x0006D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298125, XrefRangeEnd = 298127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0006F2C8 File Offset: 0x0006D4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298127, XrefRangeEnd = 298134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0006F318 File Offset: 0x0006D518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298134, XrefRangeEnd = 298136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0006F368 File Offset: 0x0006D568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298136, XrefRangeEnd = 298138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000060C3 File Offset: 0x000042C3
		public OrdinalComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0006F3A4 File Offset: 0x0006D5A4
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x000060CC File Offset: 0x000042CC
		public unsafe bool _ignoreCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrdinalComparer.NativeFieldInfoPtr__ignoreCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrdinalComparer.NativeFieldInfoPtr__ignoreCase)) = value;
			}
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCase;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
