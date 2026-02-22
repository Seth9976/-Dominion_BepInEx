using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023B RID: 571
	public class HebrewNumber : Object
	{
		// Token: 0x06002650 RID: 9808 RVA: 0x000CBA00 File Offset: 0x000C9C00
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumber()
		{
			Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr);
			HebrewNumber.NativeFieldInfoPtr_HebrewValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValues");
			HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "maxHebrewNumberCh");
			HebrewNumber.NativeFieldInfoPtr_NumberPasingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "NumberPasingState");
			HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669525);
			HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669526);
			HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100669527);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000CBAA8 File Offset: 0x000C9CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326926, RefRangeEnd = 326927, XrefRangeStart = 326680, XrefRangeEnd = 326926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int Number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000CBAE0 File Offset: 0x000C9CE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326936, RefRangeEnd = 326939, XrefRangeStart = 326927, XrefRangeEnd = 326936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000CBB2C File Offset: 0x000C9D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326945, RefRangeEnd = 326947, XrefRangeStart = 326939, XrefRangeEnd = 326945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0000D27C File Offset: 0x0000B47C
		public HebrewNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x000CBB6C File Offset: 0x000C9D6C
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x0000D285 File Offset: 0x0000B485
		public unsafe static Il2CppReferenceArray<HebrewNumber.HebrewValue> HebrewValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_HebrewValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HebrewNumber.HebrewValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_HebrewValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000CBB94 File Offset: 0x000C9D94
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x0000D297 File Offset: 0x0000B497
		public unsafe static char maxHebrewNumberCh
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_maxHebrewNumberCh, (void*)(&value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000CBBB0 File Offset: 0x000C9DB0
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x0000D2A5 File Offset: 0x0000B4A5
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<HebrewNumber.HS>> NumberPasingState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HebrewNumber.NativeFieldInfoPtr_NumberPasingState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<HebrewNumber.HS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HebrewNumber.NativeFieldInfoPtr_NumberPasingState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeFieldInfoPtr_HebrewValues;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeFieldInfoPtr_maxHebrewNumberCh;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeFieldInfoPtr_NumberPasingState;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x020005DE RID: 1502
		public enum HebrewToken
		{
			// Token: 0x04004265 RID: 16997
			Invalid = -1,
			// Token: 0x04004266 RID: 16998
			Digit400,
			// Token: 0x04004267 RID: 16999
			Digit200_300,
			// Token: 0x04004268 RID: 17000
			Digit100,
			// Token: 0x04004269 RID: 17001
			Digit10,
			// Token: 0x0400426A RID: 17002
			Digit1,
			// Token: 0x0400426B RID: 17003
			Digit6_7,
			// Token: 0x0400426C RID: 17004
			Digit7,
			// Token: 0x0400426D RID: 17005
			Digit9,
			// Token: 0x0400426E RID: 17006
			SingleQuote,
			// Token: 0x0400426F RID: 17007
			DoubleQuote
		}

		// Token: 0x020005DF RID: 1503
		public class HebrewValue : Object
		{
			// Token: 0x0600520C RID: 21004 RVA: 0x0016E6C0 File Offset: 0x0016C8C0
			// Note: this type is marked as 'beforefieldinit'.
			static HebrewValue()
			{
				Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr);
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "token");
				HebrewNumber.HebrewValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, "value");
				HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr, 100669529);
			}

			// Token: 0x0600520D RID: 21005 RVA: 0x0016E728 File Offset: 0x0016C928
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 178992, RefRangeEnd = 179019, XrefRangeStart = 178992, XrefRangeEnd = 179019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HebrewValue(HebrewNumber.HebrewToken token, int value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HebrewNumber.HebrewValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumber.HebrewValue.NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600520E RID: 21006 RVA: 0x0001F408 File Offset: 0x0001D608
			public HebrewValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014EE RID: 5358
			// (get) Token: 0x0600520F RID: 21007 RVA: 0x0016E780 File Offset: 0x0016C980
			// (set) Token: 0x06005210 RID: 21008 RVA: 0x0001F411 File Offset: 0x0001D611
			public unsafe HebrewNumber.HebrewToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_token)) = value;
				}
			}

			// Token: 0x170014EF RID: 5359
			// (get) Token: 0x06005211 RID: 21009 RVA: 0x0016E7A8 File Offset: 0x0016C9A8
			// (set) Token: 0x06005212 RID: 21010 RVA: 0x0001F42C File Offset: 0x0001D62C
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HebrewNumber.HebrewValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x04004270 RID: 17008
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04004271 RID: 17009
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04004272 RID: 17010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int32_0;
		}

		// Token: 0x020005E0 RID: 1504
		public enum HS
		{
			// Token: 0x04004274 RID: 17012
			_err = -1,
			// Token: 0x04004275 RID: 17013
			Start,
			// Token: 0x04004276 RID: 17014
			S400,
			// Token: 0x04004277 RID: 17015
			S400_400,
			// Token: 0x04004278 RID: 17016
			S400_X00,
			// Token: 0x04004279 RID: 17017
			S400_X0,
			// Token: 0x0400427A RID: 17018
			X00_DQ,
			// Token: 0x0400427B RID: 17019
			S400_X00_X0,
			// Token: 0x0400427C RID: 17020
			X0_DQ,
			// Token: 0x0400427D RID: 17021
			X,
			// Token: 0x0400427E RID: 17022
			X0,
			// Token: 0x0400427F RID: 17023
			X00,
			// Token: 0x04004280 RID: 17024
			S400_DQ,
			// Token: 0x04004281 RID: 17025
			S400_400_DQ,
			// Token: 0x04004282 RID: 17026
			S400_400_100,
			// Token: 0x04004283 RID: 17027
			S9,
			// Token: 0x04004284 RID: 17028
			X00_S9,
			// Token: 0x04004285 RID: 17029
			S9_DQ,
			// Token: 0x04004286 RID: 17030
			END = 100
		}
	}
}
