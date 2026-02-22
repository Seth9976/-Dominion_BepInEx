using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace UnityEngine.Purchasing.MiniJSON
{
	// Token: 0x02000005 RID: 5
	public static class Json : Object
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002468 File Offset: 0x00000668
		// Note: this type is marked as 'beforefieldinit'.
		static Json()
		{
			Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("Purchasing.Common.dll", "UnityEngine.Purchasing.MiniJSON", "Json");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
			Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663304);
			Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024C0 File Offset: 0x000006C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 89526, RefRangeEnd = 89537, XrefRangeStart = 89526, XrefRangeEnd = 89537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000013 RID: 19 RVA: 0x00002504 File Offset: 0x00000704
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 89512, RefRangeEnd = 89525, XrefRangeStart = 89512, XrefRangeEnd = 89525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000014 RID: 20 RVA: 0x00002092 File Offset: 0x00000292
		public Json(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x02000007 RID: 7
		public sealed class Parser : Object
		{
			// Token: 0x0600001B RID: 27 RVA: 0x000026DC File Offset: 0x000008DC
			// Note: this type is marked as 'beforefieldinit'.
			static Parser()
			{
				Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Parser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
				Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, "json");
				Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663306);
				Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663307);
				Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663308);
				Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663309);
				Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663310);
				Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663311);
				Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663312);
				Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663313);
				Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663314);
				Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663315);
				Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663316);
				Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663317);
				Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663318);
				Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663319);
				Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100663320);
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002848 File Offset: 0x00000A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89537, XrefRangeEnd = 89542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsWordBreak(char c)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002888 File Offset: 0x00000A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89542, XrefRangeEnd = 89547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600001E RID: 30 RVA: 0x000028D4 File Offset: 0x00000AD4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 89563, RefRangeEnd = 89566, XrefRangeStart = 89547, XrefRangeEnd = 89563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600001F RID: 31 RVA: 0x00002918 File Offset: 0x00000B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89566, XrefRangeEnd = 89567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x0000294C File Offset: 0x00000B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89567, XrefRangeEnd = 89582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000021 RID: 33 RVA: 0x0000298C File Offset: 0x00000B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89582, XrefRangeEnd = 89594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000022 RID: 34 RVA: 0x000029CC File Offset: 0x00000BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89594, XrefRangeEnd = 89596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000023 RID: 35 RVA: 0x00002A0C File Offset: 0x00000C0C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 89612, RefRangeEnd = 89617, XrefRangeStart = 89596, XrefRangeEnd = 89612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000024 RID: 36 RVA: 0x00002A58 File Offset: 0x00000C58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89649, RefRangeEnd = 89651, XrefRangeStart = 89617, XrefRangeEnd = 89649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ParseString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002A90 File Offset: 0x00000C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89651, XrefRangeEnd = 89664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000026 RID: 38 RVA: 0x00002AD0 File Offset: 0x00000CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89664, XrefRangeEnd = 89669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EatWhitespace()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00002B04 File Offset: 0x00000D04
			public unsafe char PeekChar
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 89674, RefRangeEnd = 89678, XrefRangeStart = 89669, XrefRangeEnd = 89674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002B40 File Offset: 0x00000D40
			public unsafe char NextChar
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 89683, RefRangeEnd = 89687, XrefRangeStart = 89678, XrefRangeEnd = 89683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00002B7C File Offset: 0x00000D7C
			public unsafe string NextWord
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 89703, RefRangeEnd = 89704, XrefRangeStart = 89687, XrefRangeEnd = 89703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002BB4 File Offset: 0x00000DB4
			public unsafe Json.Parser.TOKEN NextToken
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 89713, RefRangeEnd = 89724, XrefRangeStart = 89704, XrefRangeEnd = 89713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600002B RID: 43 RVA: 0x000020A4 File Offset: 0x000002A4
			public Parser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00002BF0 File Offset: 0x00000DF0
			// (set) Token: 0x0600002D RID: 45 RVA: 0x000020AD File Offset: 0x000002AD
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

			// Token: 0x0400000E RID: 14
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x0400000F RID: 15
			private static readonly IntPtr NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0;

			// Token: 0x04000010 RID: 16
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

			// Token: 0x04000011 RID: 17
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;

			// Token: 0x04000012 RID: 18
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000013 RID: 19
			private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;

			// Token: 0x04000014 RID: 20
			private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;

			// Token: 0x04000015 RID: 21
			private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;

			// Token: 0x04000016 RID: 22
			private static readonly IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;

			// Token: 0x04000017 RID: 23
			private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;

			// Token: 0x04000018 RID: 24
			private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;

			// Token: 0x04000019 RID: 25
			private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

			// Token: 0x0400001A RID: 26
			private static readonly IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;

			// Token: 0x0400001B RID: 27
			private static readonly IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;

			// Token: 0x0400001C RID: 28
			private static readonly IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;

			// Token: 0x0400001D RID: 29
			private static readonly IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

			// Token: 0x02000009 RID: 9
			public enum TOKEN
			{
				// Token: 0x04000027 RID: 39
				NONE,
				// Token: 0x04000028 RID: 40
				CURLY_OPEN,
				// Token: 0x04000029 RID: 41
				CURLY_CLOSE,
				// Token: 0x0400002A RID: 42
				SQUARED_OPEN,
				// Token: 0x0400002B RID: 43
				SQUARED_CLOSE,
				// Token: 0x0400002C RID: 44
				COLON,
				// Token: 0x0400002D RID: 45
				COMMA,
				// Token: 0x0400002E RID: 46
				STRING,
				// Token: 0x0400002F RID: 47
				NUMBER,
				// Token: 0x04000030 RID: 48
				TRUE,
				// Token: 0x04000031 RID: 49
				FALSE,
				// Token: 0x04000032 RID: 50
				NULL
			}
		}

		// Token: 0x02000008 RID: 8
		public sealed class Serializer : Object
		{
			// Token: 0x0600002E RID: 46 RVA: 0x00002C20 File Offset: 0x00000E20
			// Note: this type is marked as 'beforefieldinit'.
			static Serializer()
			{
				Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, "Serializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
				Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, "builder");
				Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663321);
				Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663322);
				Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663323);
				Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663324);
				Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663325);
				Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663326);
				Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100663327);
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002CEC File Offset: 0x00000EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89724, XrefRangeEnd = 89729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Serializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002D28 File Offset: 0x00000F28
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 89512, RefRangeEnd = 89525, XrefRangeStart = 89512, XrefRangeEnd = 89525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000031 RID: 49 RVA: 0x00002D64 File Offset: 0x00000F64
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89764, XrefRangeStart = 89729, XrefRangeEnd = 89759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000032 RID: 50 RVA: 0x00002DA8 File Offset: 0x00000FA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89797, RefRangeEnd = 89798, XrefRangeStart = 89764, XrefRangeEnd = 89797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000033 RID: 51 RVA: 0x00002DEC File Offset: 0x00000FEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89822, RefRangeEnd = 89823, XrefRangeStart = 89798, XrefRangeEnd = 89822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000034 RID: 52 RVA: 0x00002E30 File Offset: 0x00001030
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 89868, RefRangeEnd = 89872, XrefRangeStart = 89823, XrefRangeEnd = 89868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000035 RID: 53 RVA: 0x00002E74 File Offset: 0x00001074
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89888, RefRangeEnd = 89889, XrefRangeStart = 89872, XrefRangeEnd = 89888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000036 RID: 54 RVA: 0x000020CC File Offset: 0x000002CC
			public Serializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00002EB8 File Offset: 0x000010B8
			// (set) Token: 0x06000038 RID: 56 RVA: 0x000020D5 File Offset: 0x000002D5
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

			// Token: 0x0400001E RID: 30
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x0400001F RID: 31
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04000020 RID: 32
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

			// Token: 0x04000021 RID: 33
			private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;

			// Token: 0x04000022 RID: 34
			private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;

			// Token: 0x04000023 RID: 35
			private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;

			// Token: 0x04000024 RID: 36
			private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;

			// Token: 0x04000025 RID: 37
			private static readonly IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;
		}
	}
}
