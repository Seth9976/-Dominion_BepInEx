using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DB RID: 219
	public class CaseInsensitiveAscii : Object
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x0003FE50 File Offset: 0x0003E050
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveAscii()
		{
			Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CaseInsensitiveAscii");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr);
			CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, "StaticInstance");
			CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, "AsciiToLower");
			CaseInsensitiveAscii.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100665069);
			CaseInsensitiveAscii.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100665070);
			CaseInsensitiveAscii.NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100665071);
			CaseInsensitiveAscii.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100665072);
			CaseInsensitiveAscii.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100665073);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0003FF0C File Offset: 0x0003E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47076, XrefRangeEnd = 47086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object myObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0003FF5C File Offset: 0x0003E15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47086, XrefRangeEnd = 47095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object firstObject, Object secondObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47095, XrefRangeEnd = 47102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FastGetHashCode(string myString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(myString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0004000C File Offset: 0x0003E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47102, XrefRangeEnd = 47125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object firstObject, Object secondObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0004006C File Offset: 0x0003E26C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveAscii()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00006E8A File Offset: 0x0000508A
		public CaseInsensitiveAscii(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x000400A8 File Offset: 0x0003E2A8
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00006E93 File Offset: 0x00005093
		public unsafe static CaseInsensitiveAscii StaticInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveAscii>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x000400D0 File Offset: 0x0003E2D0
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00006EA5 File Offset: 0x000050A5
		public unsafe static Il2CppStructArray<byte> AsciiToLower
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_StaticInstance;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_AsciiToLower;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
