using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace ANMiniJSON
{
	// Token: 0x0200030C RID: 780
	public static class Json : Object
	{
		// Token: 0x06002CE9 RID: 11497 RVA: 0x000C03A0 File Offset: 0x000BE5A0
		// Note: this type is marked as 'beforefieldinit'.
		static Json()
		{
			Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "ANMiniJSON", "Json");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
			Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100669184);
			Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100669185);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000C03F8 File Offset: 0x000BE5F8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 211504, RefRangeEnd = 211524, XrefRangeStart = 211503, XrefRangeEnd = 211504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002CEB RID: 11499 RVA: 0x000C043C File Offset: 0x000BE63C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 211525, RefRangeEnd = 211529, XrefRangeStart = 211524, XrefRangeEnd = 211525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06002CEC RID: 11500 RVA: 0x00011701 File Offset: 0x0000F901
		public Json(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x020003C9 RID: 969
		public sealed class Parser : Object
		{
			// Token: 0x06003848 RID: 14408 RVA: 0x000E5318 File Offset: 0x000E3518
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
				Json.Parser.NativeFieldInfoPtr_WHITE_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WHITE_SPACE");
				Json.Parser.NativeFieldInfoPtr_WORD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "WORD_BREAK");
				Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "json");
				Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670416);
				Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670417);
				Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670418);
				Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670419);
				Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670420);
				Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670421);
				Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670422);
				Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670423);
				Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670424);
				Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670425);
				Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670426);
				Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670427);
				Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670428);
				Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670429);
			}

			// Token: 0x06003849 RID: 14409 RVA: 0x000E5498 File Offset: 0x000E3698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211159, XrefRangeEnd = 211164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600384A RID: 14410 RVA: 0x000E54E4 File Offset: 0x000E36E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211180, RefRangeEnd = 211181, XrefRangeStart = 211164, XrefRangeEnd = 211180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600384B RID: 14411 RVA: 0x000E5528 File Offset: 0x000E3728
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

			// Token: 0x0600384C RID: 14412 RVA: 0x000E555C File Offset: 0x000E375C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211181, XrefRangeEnd = 211196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600384D RID: 14413 RVA: 0x000E559C File Offset: 0x000E379C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211196, XrefRangeEnd = 211208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600384E RID: 14414 RVA: 0x000E55DC File Offset: 0x000E37DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211208, XrefRangeEnd = 211210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600384F RID: 14415 RVA: 0x000E561C File Offset: 0x000E381C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 211226, RefRangeEnd = 211231, XrefRangeStart = 211210, XrefRangeEnd = 211226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003850 RID: 14416 RVA: 0x000E5668 File Offset: 0x000E3868
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 211261, RefRangeEnd = 211263, XrefRangeStart = 211231, XrefRangeEnd = 211261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ParseString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003851 RID: 14417 RVA: 0x000E56A0 File Offset: 0x000E38A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211263, XrefRangeEnd = 211272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003852 RID: 14418 RVA: 0x000E56E0 File Offset: 0x000E38E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211272, XrefRangeEnd = 211279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EatWhitespace()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06003853 RID: 14419 RVA: 0x000E5714 File Offset: 0x000E3914
			public unsafe char PeekChar
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 211284, RefRangeEnd = 211291, XrefRangeStart = 211279, XrefRangeEnd = 211284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06003854 RID: 14420 RVA: 0x000E5750 File Offset: 0x000E3950
			public unsafe char NextChar
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 211296, RefRangeEnd = 211300, XrefRangeStart = 211291, XrefRangeEnd = 211296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D4F RID: 3407
			// (get) Token: 0x06003855 RID: 14421 RVA: 0x000E578C File Offset: 0x000E398C
			public unsafe string NextWord
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 211314, RefRangeEnd = 211315, XrefRangeStart = 211300, XrefRangeEnd = 211314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06003856 RID: 14422 RVA: 0x000E57C4 File Offset: 0x000E39C4
			public unsafe Json.Parser.TOKEN NextToken
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 211326, RefRangeEnd = 211337, XrefRangeStart = 211315, XrefRangeEnd = 211326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003857 RID: 14423 RVA: 0x00015D06 File Offset: 0x00013F06
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x06003858 RID: 14424 RVA: 0x000E5800 File Offset: 0x000E3A00
			// (set) Token: 0x06003859 RID: 14425 RVA: 0x00015D0F File Offset: 0x00013F0F
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

			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x0600385A RID: 14426 RVA: 0x000E5820 File Offset: 0x000E3A20
			// (set) Token: 0x0600385B RID: 14427 RVA: 0x00015D21 File Offset: 0x00013F21
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

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x0600385C RID: 14428 RVA: 0x000E5840 File Offset: 0x000E3A40
			// (set) Token: 0x0600385D RID: 14429 RVA: 0x00015D33 File Offset: 0x00013F33
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

			// Token: 0x040032D3 RID: 13011
			private static readonly IntPtr NativeFieldInfoPtr_WHITE_SPACE;

			// Token: 0x040032D4 RID: 13012
			private static readonly IntPtr NativeFieldInfoPtr_WORD_BREAK;

			// Token: 0x040032D5 RID: 13013
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x040032D6 RID: 13014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

			// Token: 0x040032D7 RID: 13015
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;

			// Token: 0x040032D8 RID: 13016
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040032D9 RID: 13017
			private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;

			// Token: 0x040032DA RID: 13018
			private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;

			// Token: 0x040032DB RID: 13019
			private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;

			// Token: 0x040032DC RID: 13020
			private static readonly IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;

			// Token: 0x040032DD RID: 13021
			private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;

			// Token: 0x040032DE RID: 13022
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;

			// Token: 0x040032DF RID: 13023
			private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

			// Token: 0x040032E0 RID: 13024
			private static readonly IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;

			// Token: 0x040032E1 RID: 13025
			private static readonly IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;

			// Token: 0x040032E2 RID: 13026
			private static readonly IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;

			// Token: 0x040032E3 RID: 13027
			private static readonly IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

			// Token: 0x02000401 RID: 1025
			public enum TOKEN
			{
				// Token: 0x0400343A RID: 13370
				NONE,
				// Token: 0x0400343B RID: 13371
				CURLY_OPEN,
				// Token: 0x0400343C RID: 13372
				CURLY_CLOSE,
				// Token: 0x0400343D RID: 13373
				SQUARED_OPEN,
				// Token: 0x0400343E RID: 13374
				SQUARED_CLOSE,
				// Token: 0x0400343F RID: 13375
				COLON,
				// Token: 0x04003440 RID: 13376
				COMMA,
				// Token: 0x04003441 RID: 13377
				STRING,
				// Token: 0x04003442 RID: 13378
				NUMBER,
				// Token: 0x04003443 RID: 13379
				TRUE,
				// Token: 0x04003444 RID: 13380
				FALSE,
				// Token: 0x04003445 RID: 13381
				NULL
			}
		}

		// Token: 0x020003CA RID: 970
		public sealed class Serializer : Object
		{
			// Token: 0x0600385E RID: 14430 RVA: 0x000E5870 File Offset: 0x000E3A70
			// Note: this type is marked as 'beforefieldinit'.
			static Serializer()
			{
				Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Serializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
				Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, "builder");
				Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670430);
				Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670431);
				Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670432);
				Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670433);
				Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670434);
				Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670435);
				Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670436);
			}

			// Token: 0x0600385F RID: 14431 RVA: 0x000E593C File Offset: 0x000E3B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211337, XrefRangeEnd = 211342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003860 RID: 14432 RVA: 0x000E5978 File Offset: 0x000E3B78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211352, RefRangeEnd = 211353, XrefRangeStart = 211342, XrefRangeEnd = 211352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003861 RID: 14433 RVA: 0x000E59B4 File Offset: 0x000E3BB4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 211373, RefRangeEnd = 211376, XrefRangeStart = 211353, XrefRangeEnd = 211373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003862 RID: 14434 RVA: 0x000E59F8 File Offset: 0x000E3BF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211409, RefRangeEnd = 211410, XrefRangeStart = 211376, XrefRangeEnd = 211409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003863 RID: 14435 RVA: 0x000E5A3C File Offset: 0x000E3C3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211434, RefRangeEnd = 211435, XrefRangeStart = 211410, XrefRangeEnd = 211434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003864 RID: 14436 RVA: 0x000E5A80 File Offset: 0x000E3C80
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 211484, RefRangeEnd = 211488, XrefRangeStart = 211435, XrefRangeEnd = 211484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003865 RID: 14437 RVA: 0x000E5AC4 File Offset: 0x000E3CC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211502, RefRangeEnd = 211503, XrefRangeStart = 211488, XrefRangeEnd = 211502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06003866 RID: 14438 RVA: 0x00015D52 File Offset: 0x00013F52
			public Serializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x06003867 RID: 14439 RVA: 0x000E5B08 File Offset: 0x000E3D08
			// (set) Token: 0x06003868 RID: 14440 RVA: 0x00015D5B File Offset: 0x00013F5B
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

			// Token: 0x040032E4 RID: 13028
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x040032E5 RID: 13029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040032E6 RID: 13030
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

			// Token: 0x040032E7 RID: 13031
			private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;

			// Token: 0x040032E8 RID: 13032
			private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;

			// Token: 0x040032E9 RID: 13033
			private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;

			// Token: 0x040032EA RID: 13034
			private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;

			// Token: 0x040032EB RID: 13035
			private static readonly IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;
		}
	}
}
