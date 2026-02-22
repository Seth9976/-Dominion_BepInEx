using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000011 RID: 17
	public static class TMPro_ExtensionMethods : global::Il2CppSystem.Object
	{
		// Token: 0x0600020D RID: 525 RVA: 0x0001121C File Offset: 0x0000F41C
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_ExtensionMethods()
		{
			Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663539);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663540);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663541);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663542);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663543);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663544);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663545);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663546);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663547);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663548);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663549);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663550);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663551);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663552);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663553);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663554);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001138C File Offset: 0x0000F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137335, XrefRangeEnd = 137340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> ToIntArray(this string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000113D0 File Offset: 0x0000F5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137340, XrefRangeEnd = 137345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ArrayToString(this Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001140C File Offset: 0x0000F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137345, XrefRangeEnd = 137355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00011448 File Offset: 0x0000F648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137366, RefRangeEnd = 137367, XrefRangeStart = 137355, XrefRangeEnd = 137366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UintToString(this List<uint> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00011484 File Offset: 0x0000F684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137367, XrefRangeEnd = 137374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000114DC File Offset: 0x0000F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137374, XrefRangeEnd = 137377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindInstanceID<T>(this List<T> list, T target) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = target;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref target;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00011568 File Offset: 0x0000F768
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137377, RefRangeEnd = 137383, XrefRangeStart = 137377, XrefRangeEnd = 137377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000115B4 File Offset: 0x0000F7B4
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00011600 File Offset: 0x0000F800
		[CallerCount(0)]
		public unsafe static bool Compare(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001164C File Offset: 0x0000F84C
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00011698 File Offset: 0x0000F898
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 137384, RefRangeEnd = 137396, XrefRangeStart = 137383, XrefRangeEnd = 137384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Multiply(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000116E4 File Offset: 0x0000F8E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 137384, RefRangeEnd = 137396, XrefRangeStart = 137384, XrefRangeEnd = 137396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00011730 File Offset: 0x0000F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137396, XrefRangeEnd = 137401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, float tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001177C File Offset: 0x0000F97C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137403, RefRangeEnd = 137407, XrefRangeStart = 137401, XrefRangeEnd = 137403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color MinAlpha(this Color c1, Color c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000117C8 File Offset: 0x0000F9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137407, RefRangeEnd = 137409, XrefRangeStart = 137407, XrefRangeEnd = 137407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(this Vector3 v1, Vector3 v2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011824 File Offset: 0x0000FA24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137409, RefRangeEnd = 137411, XrefRangeStart = 137409, XrefRangeEnd = 137409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(this Quaternion q1, Quaternion q2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002CB5 File Offset: 0x00000EB5
		public TMPro_ExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0;

		// Token: 0x02000078 RID: 120
		private sealed class MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>
		{
			// Token: 0x04000B8E RID: 2958
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
