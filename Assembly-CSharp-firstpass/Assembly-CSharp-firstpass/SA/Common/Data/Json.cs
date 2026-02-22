using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace SA.Common.Data
{
	// Token: 0x0200031F RID: 799
	public static class Json : Object
	{
		// Token: 0x06002F21 RID: 12065 RVA: 0x000C9634 File Offset: 0x000C7834
		// Note: this type is marked as 'beforefieldinit'.
		static Json()
		{
			Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Data", "Json");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
			Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100669535);
			Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100669536);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x000C968C File Offset: 0x000C788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219839, XrefRangeEnd = 219840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002F23 RID: 12067 RVA: 0x000C96D0 File Offset: 0x000C78D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219840, XrefRangeEnd = 219841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002F24 RID: 12068 RVA: 0x00012076 File Offset: 0x00010276
		public Json(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x020003DD RID: 989
		public sealed class Parser : Object
		{
			// Token: 0x06003929 RID: 14633 RVA: 0x000E7C9C File Offset: 0x000E5E9C
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
				Json.Parser.NativeFieldInfoPtr_WHITE_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WHITE_SPACE");
				Json.Parser.NativeFieldInfoPtr_WORD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WORD_BREAK");
				Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "json");
				Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670500);
				Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670501);
				Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670502);
				Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670503);
				Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670504);
				Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670505);
				Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670506);
				Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670507);
				Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670508);
				Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670509);
				Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670510);
				Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670511);
				Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670512);
				Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670513);
			}

			// Token: 0x0600392A RID: 14634 RVA: 0x000E7E1C File Offset: 0x000E601C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219494, XrefRangeEnd = 219499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600392B RID: 14635 RVA: 0x000E7E68 File Offset: 0x000E6068
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219515, RefRangeEnd = 219516, XrefRangeStart = 219499, XrefRangeEnd = 219515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600392C RID: 14636 RVA: 0x000E7EAC File Offset: 0x000E60AC
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

			// Token: 0x0600392D RID: 14637 RVA: 0x000E7EE0 File Offset: 0x000E60E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219516, XrefRangeEnd = 219531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600392E RID: 14638 RVA: 0x000E7F20 File Offset: 0x000E6120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219531, XrefRangeEnd = 219543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600392F RID: 14639 RVA: 0x000E7F60 File Offset: 0x000E6160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219543, XrefRangeEnd = 219545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003930 RID: 14640 RVA: 0x000E7FA0 File Offset: 0x000E61A0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 219561, RefRangeEnd = 219566, XrefRangeStart = 219545, XrefRangeEnd = 219561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003931 RID: 14641 RVA: 0x000E7FEC File Offset: 0x000E61EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219596, RefRangeEnd = 219598, XrefRangeStart = 219566, XrefRangeEnd = 219596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ParseString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003932 RID: 14642 RVA: 0x000E8024 File Offset: 0x000E6224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219598, XrefRangeEnd = 219607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003933 RID: 14643 RVA: 0x000E8064 File Offset: 0x000E6264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219607, XrefRangeEnd = 219614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EatWhitespace()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06003934 RID: 14644 RVA: 0x000E8098 File Offset: 0x000E6298
			public unsafe char PeekChar
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 219619, RefRangeEnd = 219626, XrefRangeStart = 219614, XrefRangeEnd = 219619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06003935 RID: 14645 RVA: 0x000E80D4 File Offset: 0x000E62D4
			public unsafe char NextChar
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 219631, RefRangeEnd = 219635, XrefRangeStart = 219626, XrefRangeEnd = 219631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x06003936 RID: 14646 RVA: 0x000E8110 File Offset: 0x000E6310
			public unsafe string NextWord
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 219649, RefRangeEnd = 219650, XrefRangeStart = 219635, XrefRangeEnd = 219649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x06003937 RID: 14647 RVA: 0x000E8148 File Offset: 0x000E6348
			public unsafe Json.Parser.TOKEN NextToken
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 219661, RefRangeEnd = 219672, XrefRangeStart = 219650, XrefRangeEnd = 219661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003938 RID: 14648 RVA: 0x00016283 File Offset: 0x00014483
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06003939 RID: 14649 RVA: 0x000E8184 File Offset: 0x000E6384
			// (set) Token: 0x0600393A RID: 14650 RVA: 0x0001628C File Offset: 0x0001448C
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

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x0600393B RID: 14651 RVA: 0x000E81A4 File Offset: 0x000E63A4
			// (set) Token: 0x0600393C RID: 14652 RVA: 0x0001629E File Offset: 0x0001449E
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

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x0600393D RID: 14653 RVA: 0x000E81C4 File Offset: 0x000E63C4
			// (set) Token: 0x0600393E RID: 14654 RVA: 0x000162B0 File Offset: 0x000144B0
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

			// Token: 0x04003360 RID: 13152
			private static readonly IntPtr NativeFieldInfoPtr_WHITE_SPACE;

			// Token: 0x04003361 RID: 13153
			private static readonly IntPtr NativeFieldInfoPtr_WORD_BREAK;

			// Token: 0x04003362 RID: 13154
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x04003363 RID: 13155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

			// Token: 0x04003364 RID: 13156
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;

			// Token: 0x04003365 RID: 13157
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003366 RID: 13158
			private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;

			// Token: 0x04003367 RID: 13159
			private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;

			// Token: 0x04003368 RID: 13160
			private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;

			// Token: 0x04003369 RID: 13161
			private static readonly IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;

			// Token: 0x0400336A RID: 13162
			private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;

			// Token: 0x0400336B RID: 13163
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;

			// Token: 0x0400336C RID: 13164
			private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

			// Token: 0x0400336D RID: 13165
			private static readonly IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;

			// Token: 0x0400336E RID: 13166
			private static readonly IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;

			// Token: 0x0400336F RID: 13167
			private static readonly IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;

			// Token: 0x04003370 RID: 13168
			private static readonly IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

			// Token: 0x02000402 RID: 1026
			public enum TOKEN
			{
				// Token: 0x04003447 RID: 13383
				NONE,
				// Token: 0x04003448 RID: 13384
				CURLY_OPEN,
				// Token: 0x04003449 RID: 13385
				CURLY_CLOSE,
				// Token: 0x0400344A RID: 13386
				SQUARED_OPEN,
				// Token: 0x0400344B RID: 13387
				SQUARED_CLOSE,
				// Token: 0x0400344C RID: 13388
				COLON,
				// Token: 0x0400344D RID: 13389
				COMMA,
				// Token: 0x0400344E RID: 13390
				STRING,
				// Token: 0x0400344F RID: 13391
				NUMBER,
				// Token: 0x04003450 RID: 13392
				TRUE,
				// Token: 0x04003451 RID: 13393
				FALSE,
				// Token: 0x04003452 RID: 13394
				NULL
			}
		}

		// Token: 0x020003DE RID: 990
		public sealed class Serializer : Object
		{
			// Token: 0x0600393F RID: 14655 RVA: 0x000E81F4 File Offset: 0x000E63F4
			// Note: this type is marked as 'beforefieldinit'.
			static Serializer()
			{
				Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Serializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
				Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, "builder");
				Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670514);
				Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670515);
				Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670516);
				Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670517);
				Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670518);
				Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670519);
				Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670520);
			}

			// Token: 0x06003940 RID: 14656 RVA: 0x000E82C0 File Offset: 0x000E64C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219672, XrefRangeEnd = 219677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003941 RID: 14657 RVA: 0x000E82FC File Offset: 0x000E64FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219687, RefRangeEnd = 219689, XrefRangeStart = 219677, XrefRangeEnd = 219687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003942 RID: 14658 RVA: 0x000E8338 File Offset: 0x000E6538
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 219709, RefRangeEnd = 219712, XrefRangeStart = 219689, XrefRangeEnd = 219709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003943 RID: 14659 RVA: 0x000E837C File Offset: 0x000E657C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219745, RefRangeEnd = 219746, XrefRangeStart = 219712, XrefRangeEnd = 219745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003944 RID: 14660 RVA: 0x000E83C0 File Offset: 0x000E65C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219770, RefRangeEnd = 219771, XrefRangeStart = 219746, XrefRangeEnd = 219770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003945 RID: 14661 RVA: 0x000E8404 File Offset: 0x000E6604
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 219820, RefRangeEnd = 219824, XrefRangeStart = 219771, XrefRangeEnd = 219820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003946 RID: 14662 RVA: 0x000E8448 File Offset: 0x000E6648
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219838, RefRangeEnd = 219839, XrefRangeStart = 219824, XrefRangeEnd = 219838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003947 RID: 14663 RVA: 0x000162CF File Offset: 0x000144CF
			public Serializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x06003948 RID: 14664 RVA: 0x000E848C File Offset: 0x000E668C
			// (set) Token: 0x06003949 RID: 14665 RVA: 0x000162D8 File Offset: 0x000144D8
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

			// Token: 0x04003371 RID: 13169
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x04003372 RID: 13170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04003373 RID: 13171
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

			// Token: 0x04003374 RID: 13172
			private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;

			// Token: 0x04003375 RID: 13173
			private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;

			// Token: 0x04003376 RID: 13174
			private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;

			// Token: 0x04003377 RID: 13175
			private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;

			// Token: 0x04003378 RID: 13176
			private static readonly IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;
		}
	}
}
