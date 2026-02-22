using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000016 RID: 22
	public static class Json : Object
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00006890 File Offset: 0x00004A90
		// Note: this type is marked as 'beforefieldinit'.
		static Json()
		{
			Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "Json");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
			Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663433);
			Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663434);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000068E8 File Offset: 0x00004AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127362, XrefRangeEnd = 127363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Deserialize(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000692C File Offset: 0x00004B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127210, RefRangeEnd = 127211, XrefRangeStart = 127210, XrefRangeEnd = 127211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Serialize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000263E File Offset: 0x0000083E
		public Json(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x02000024 RID: 36
		public sealed class Parser : Object
		{
			// Token: 0x06000140 RID: 320 RVA: 0x000071D4 File Offset: 0x000053D4
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
				Json.Parser.NativeFieldInfoPtr_WHITE_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WHITE_SPACE");
				Json.Parser.NativeFieldInfoPtr_WORD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WORD_BREAK");
				Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "json");
				Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663447);
				Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663448);
				Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663449);
				Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663450);
				Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663451);
				Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663452);
				Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663453);
				Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663454);
				Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663455);
				Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663456);
				Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663457);
				Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663458);
				Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663459);
				Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663460);
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00007354 File Offset: 0x00005554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127015, XrefRangeEnd = 127020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Parser(string jsonString)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000142 RID: 322 RVA: 0x000073A0 File Offset: 0x000055A0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 127036, RefRangeEnd = 127039, XrefRangeStart = 127020, XrefRangeEnd = 127036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Object Parse(string jsonString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000143 RID: 323 RVA: 0x000073E4 File Offset: 0x000055E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00007418 File Offset: 0x00005618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127039, XrefRangeEnd = 127054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, Object> ParseObject()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00007458 File Offset: 0x00005658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127054, XrefRangeEnd = 127066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<Object> ParseArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00007498 File Offset: 0x00005698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127066, XrefRangeEnd = 127068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x000074D8 File Offset: 0x000056D8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 127084, RefRangeEnd = 127089, XrefRangeStart = 127068, XrefRangeEnd = 127084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseByToken(Json.Parser.TOKEN token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref token;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00007524 File Offset: 0x00005724
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 127119, RefRangeEnd = 127121, XrefRangeStart = 127089, XrefRangeEnd = 127119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ParseString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000149 RID: 329 RVA: 0x0000755C File Offset: 0x0000575C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127121, XrefRangeEnd = 127130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseNumber()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600014A RID: 330 RVA: 0x0000759C File Offset: 0x0000579C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127130, XrefRangeEnd = 127137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EatWhitespace()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600014B RID: 331 RVA: 0x000075D0 File Offset: 0x000057D0
			public unsafe char PeekChar
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 127142, RefRangeEnd = 127149, XrefRangeStart = 127137, XrefRangeEnd = 127142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600014C RID: 332 RVA: 0x0000760C File Offset: 0x0000580C
			public unsafe char NextChar
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 127154, RefRangeEnd = 127158, XrefRangeStart = 127149, XrefRangeEnd = 127154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600014D RID: 333 RVA: 0x00007648 File Offset: 0x00005848
			public unsafe string NextWord
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 127172, RefRangeEnd = 127173, XrefRangeStart = 127158, XrefRangeEnd = 127172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00007680 File Offset: 0x00005880
			public unsafe Json.Parser.TOKEN NextToken
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 127184, RefRangeEnd = 127195, XrefRangeStart = 127173, XrefRangeEnd = 127184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600014F RID: 335 RVA: 0x000026F2 File Offset: 0x000008F2
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000150 RID: 336 RVA: 0x000076BC File Offset: 0x000058BC
			// (set) Token: 0x06000151 RID: 337 RVA: 0x000026FB File Offset: 0x000008FB
			public unsafe static string WHITE_SPACE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Json.Parser.NativeFieldInfoPtr_WHITE_SPACE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Json.Parser.NativeFieldInfoPtr_WHITE_SPACE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000152 RID: 338 RVA: 0x000076DC File Offset: 0x000058DC
			// (set) Token: 0x06000153 RID: 339 RVA: 0x0000270D File Offset: 0x0000090D
			public unsafe static string WORD_BREAK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000154 RID: 340 RVA: 0x000076FC File Offset: 0x000058FC
			// (set) Token: 0x06000155 RID: 341 RVA: 0x0000271F File Offset: 0x0000091F
			public unsafe StringReader json
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeFieldInfoPtr_WHITE_SPACE;

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeFieldInfoPtr_WORD_BREAK;

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040000FC RID: 252
			private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;

			// Token: 0x04000100 RID: 256
			private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

			// Token: 0x02000026 RID: 38
			public enum TOKEN
			{
				// Token: 0x04000110 RID: 272
				NONE,
				// Token: 0x04000111 RID: 273
				CURLY_OPEN,
				// Token: 0x04000112 RID: 274
				CURLY_CLOSE,
				// Token: 0x04000113 RID: 275
				SQUARED_OPEN,
				// Token: 0x04000114 RID: 276
				SQUARED_CLOSE,
				// Token: 0x04000115 RID: 277
				COLON,
				// Token: 0x04000116 RID: 278
				COMMA,
				// Token: 0x04000117 RID: 279
				STRING,
				// Token: 0x04000118 RID: 280
				NUMBER,
				// Token: 0x04000119 RID: 281
				TRUE,
				// Token: 0x0400011A RID: 282
				FALSE,
				// Token: 0x0400011B RID: 283
				NULL
			}
		}

		// Token: 0x02000025 RID: 37
		public sealed class Serializer : Object
		{
			// Token: 0x06000156 RID: 342 RVA: 0x0000772C File Offset: 0x0000592C
			// Note: this type is marked as 'beforefieldinit'.
			static Serializer()
			{
				Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Serializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
				Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, "builder");
				Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663461);
				Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663462);
				Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663463);
				Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663464);
				Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663465);
				Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663466);
				Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663467);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000077F8 File Offset: 0x000059F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127195, XrefRangeEnd = 127200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00007834 File Offset: 0x00005A34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127210, RefRangeEnd = 127211, XrefRangeStart = 127200, XrefRangeEnd = 127210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Serialize(Object obj)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00007870 File Offset: 0x00005A70
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 127231, RefRangeEnd = 127235, XrefRangeStart = 127211, XrefRangeEnd = 127231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015A RID: 346 RVA: 0x000078B4 File Offset: 0x00005AB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127268, RefRangeEnd = 127269, XrefRangeStart = 127235, XrefRangeEnd = 127268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeObject(IDictionary obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015B RID: 347 RVA: 0x000078F8 File Offset: 0x00005AF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127293, RefRangeEnd = 127294, XrefRangeStart = 127269, XrefRangeEnd = 127293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeArray(IList anArray)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(anArray);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015C RID: 348 RVA: 0x0000793C File Offset: 0x00005B3C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 127343, RefRangeEnd = 127347, XrefRangeStart = 127294, XrefRangeEnd = 127343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeString(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00007980 File Offset: 0x00005B80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127361, RefRangeEnd = 127362, XrefRangeStart = 127347, XrefRangeEnd = 127361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SerializeOther(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x0000273E File Offset: 0x0000093E
			public Serializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600015F RID: 351 RVA: 0x000079C4 File Offset: 0x00005BC4
			// (set) Token: 0x06000160 RID: 352 RVA: 0x00002747 File Offset: 0x00000947
			public unsafe StringBuilder builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;
		}
	}
}
