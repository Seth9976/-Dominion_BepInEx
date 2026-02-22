using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000134 RID: 308
	public static class ParameterizedStrings : Object
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x00086C68 File Offset: 0x00084E68
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterizedStrings()
		{
			Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParameterizedStrings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr);
			ParameterizedStrings.NativeFieldInfoPtr__cachedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "_cachedStack");
			ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667051);
			ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667052);
			ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667053);
			ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667054);
			ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667055);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667056);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667057);
			ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667058);
			ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667059);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00086D60 File Offset: 0x00084F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308863, RefRangeEnd = 308864, XrefRangeStart = 308851, XrefRangeEnd = 308863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Evaluate(string format, [Optional] Il2CppReferenceArray<ParameterizedStrings.FormatParam> args)
		{
			if (args == null)
			{
				args = new Il2CppStructArray<ParameterizedStrings.FormatParam>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00086DBC File Offset: 0x00084FBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308957, RefRangeEnd = 308960, XrefRangeStart = 308864, XrefRangeEnd = 308957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateInternal(string format, ref int pos, Il2CppReferenceArray<ParameterizedStrings.FormatParam> args, ParameterizedStrings.LowLevelStack stack, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stack);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			return IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00086E80 File Offset: 0x00085080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278482, RefRangeEnd = 278484, XrefRangeStart = 278482, XrefRangeEnd = 278484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AsBool(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00086EC0 File Offset: 0x000850C0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 278727, RefRangeEnd = 278739, XrefRangeStart = 278727, XrefRangeEnd = 278739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AsInt(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00086F00 File Offset: 0x00085100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308960, XrefRangeEnd = 308966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringFromAsciiBytes(Il2CppStructArray<byte> buffer, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00086F58 File Offset: 0x00085158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308971, RefRangeEnd = 308973, XrefRangeStart = 308966, XrefRangeEnd = 308971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, string arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00086FC8 File Offset: 0x000851C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308976, RefRangeEnd = 308978, XrefRangeStart = 308973, XrefRangeEnd = 308976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, int arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00087034 File Offset: 0x00085234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309002, RefRangeEnd = 309003, XrefRangeStart = 308978, XrefRangeEnd = 309002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatPrintF(string format, Object arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00087084 File Offset: 0x00085284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309009, RefRangeEnd = 309011, XrefRangeStart = 309003, XrefRangeEnd = 309009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterizedStrings.FormatParam> GetDynamicOrStaticVariables(char c, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars, out int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr7) : null;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00007D7B File Offset: 0x00005F7B
		public static string Evaluate(string format, params ParameterizedStrings.FormatParam[] args)
		{
			return ParameterizedStrings.Evaluate(format, new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(args));
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00007D89 File Offset: 0x00005F89
		public ParameterizedStrings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00087124 File Offset: 0x00085324
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00007D92 File Offset: 0x00005F92
		public unsafe static ParameterizedStrings.LowLevelStack _cachedStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedStrings.LowLevelStack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr__cachedStack;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0;

		// Token: 0x020005AD RID: 1453
		public sealed class FormatParam : ValueType
		{
			// Token: 0x06004FEE RID: 20462 RVA: 0x00166A9C File Offset: 0x00164C9C
			// Note: this type is marked as 'beforefieldinit'.
			static FormatParam()
			{
				Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "FormatParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr);
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_int32");
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_string");
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667060);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667061);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667062);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667063);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667064);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667065);
			}

			// Token: 0x06004FEF RID: 20463 RVA: 0x00166B68 File Offset: 0x00164D68
			[CallerCount(0)]
			public unsafe FormatParam(int value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FF0 RID: 20464 RVA: 0x00166BB4 File Offset: 0x00164DB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21515, RefRangeEnd = 21516, XrefRangeStart = 21515, XrefRangeEnd = 21516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormatParam(int intValue, string stringValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref intValue;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FF1 RID: 20465 RVA: 0x00166C14 File Offset: 0x00164E14
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 308804, RefRangeEnd = 308815, XrefRangeStart = 308804, XrefRangeEnd = 308804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe static implicit operator ParameterizedStrings.FormatParam(int value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParameterizedStrings.FormatParam(intPtr);
				}
			}

			// Token: 0x17001461 RID: 5217
			// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x00166C4C File Offset: 0x00164E4C
			public unsafe int Int32
			{
				[CallerCount(64)]
				[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001462 RID: 5218
			// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x00166C90 File Offset: 0x00164E90
			public unsafe string String
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 308817, RefRangeEnd = 308819, XrefRangeStart = 308815, XrefRangeEnd = 308817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001463 RID: 5219
			// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x00166CCC File Offset: 0x00164ECC
			public unsafe Object Object
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 308822, RefRangeEnd = 308823, XrefRangeStart = 308819, XrefRangeEnd = 308822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF5 RID: 20469 RVA: 0x0001E67F File Offset: 0x0001C87F
			public FormatParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004FF6 RID: 20470 RVA: 0x0001E688 File Offset: 0x0001C888
			public FormatParam()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
			}

			// Token: 0x1700145F RID: 5215
			// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x00166D10 File Offset: 0x00164F10
			// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x0001E69A File Offset: 0x0001C89A
			public unsafe int _int32
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32)) = value;
				}
			}

			// Token: 0x17001460 RID: 5216
			// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x00166D38 File Offset: 0x00164F38
			// (set) Token: 0x06004FFA RID: 20474 RVA: 0x0001E6B5 File Offset: 0x0001C8B5
			public unsafe string _string
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004105 RID: 16645
			private static readonly IntPtr NativeFieldInfoPtr__int32;

			// Token: 0x04004106 RID: 16646
			private static readonly IntPtr NativeFieldInfoPtr__string;

			// Token: 0x04004107 RID: 16647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004108 RID: 16648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0;

			// Token: 0x04004109 RID: 16649
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0;

			// Token: 0x0400410A RID: 16650
			private static readonly IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Int32_0;

			// Token: 0x0400410B RID: 16651
			private static readonly IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;

			// Token: 0x0400410C RID: 16652
			private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;
		}

		// Token: 0x020005AE RID: 1454
		public sealed class LowLevelStack : Object
		{
			// Token: 0x06004FFB RID: 20475 RVA: 0x00166D60 File Offset: 0x00164F60
			// Note: this type is marked as 'beforefieldinit'.
			static LowLevelStack()
			{
				Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "LowLevelStack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr);
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_arr");
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_count");
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667066);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667067);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667068);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667069);
			}

			// Token: 0x06004FFC RID: 20476 RVA: 0x00166E04 File Offset: 0x00165004
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308827, RefRangeEnd = 308828, XrefRangeStart = 308823, XrefRangeEnd = 308827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowLevelStack()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FFD RID: 20477 RVA: 0x00166E40 File Offset: 0x00165040
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 308828, RefRangeEnd = 308840, XrefRangeStart = 308828, XrefRangeEnd = 308828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterizedStrings.FormatParam Pop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParameterizedStrings.FormatParam(intPtr);
			}

			// Token: 0x06004FFE RID: 20478 RVA: 0x00166E78 File Offset: 0x00165078
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 308844, RefRangeEnd = 308849, XrefRangeStart = 308840, XrefRangeEnd = 308844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Push(ParameterizedStrings.FormatParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FFF RID: 20479 RVA: 0x00166EC0 File Offset: 0x001650C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308850, RefRangeEnd = 308851, XrefRangeStart = 308849, XrefRangeEnd = 308850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005000 RID: 20480 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
			public LowLevelStack(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001464 RID: 5220
			// (get) Token: 0x06005001 RID: 20481 RVA: 0x00166EF4 File Offset: 0x001650F4
			// (set) Token: 0x06005002 RID: 20482 RVA: 0x0001E6DD File Offset: 0x0001C8DD
			public unsafe Il2CppReferenceArray<ParameterizedStrings.FormatParam> _arr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001465 RID: 5221
			// (get) Token: 0x06005003 RID: 20483 RVA: 0x00166F24 File Offset: 0x00165124
			// (set) Token: 0x06005004 RID: 20484 RVA: 0x0001E6FC File Offset: 0x0001C8FC
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x0400410D RID: 16653
			private static readonly IntPtr NativeFieldInfoPtr__arr;

			// Token: 0x0400410E RID: 16654
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x0400410F RID: 16655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004110 RID: 16656
			private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_FormatParam_0;

			// Token: 0x04004111 RID: 16657
			private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_FormatParam_0;

			// Token: 0x04004112 RID: 16658
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
		}
	}
}
