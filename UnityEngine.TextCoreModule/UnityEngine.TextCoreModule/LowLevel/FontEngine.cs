using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000E RID: 14
	public sealed class FontEngine : Object
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000059FC File Offset: 0x00003BFC
		// Note: this type is marked as 'beforefieldinit'.
		static FontEngine()
		{
			Il2CppClassPointerStore<FontEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreModule.dll", "UnityEngine.TextCore.LowLevel", "FontEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontEngine>.NativeClassPtr);
			FontEngine.NativeFieldInfoPtr_s_Glyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_Glyphs");
			FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphIndexes_MarshallingArray_A");
			FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_IN");
			FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphMarshallingStruct_OUT");
			FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_FreeGlyphRects");
			FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_UsedGlyphRects");
			FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_PairAdjustmentRecords_MarshallingArray");
			FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, "s_GlyphLookupDictionary");
			FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663375);
			FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663376);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663377);
			FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663378);
			FontEngine.NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663379);
			FontEngine.NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663380);
			FontEngine.NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663381);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663382);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663383);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663384);
			FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663385);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663386);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663387);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663388);
			FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663389);
			FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663390);
			FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663391);
			FontEngine.NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663392);
			FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663393);
			FontEngine.NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663394);
			FontEngine.NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663395);
			FontEngine.NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontEngine>.NativeClassPtr, 100663396);
			FontEngine.DestroyFontEngine_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.DestroyFontEngine_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::DestroyFontEngine_Internal");
			FontEngine.SendCancellationRequest_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.SendCancellationRequest_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SendCancellationRequest_Internal");
			FontEngine.get_isProcessingDoneDelegateField = IL2CPP.ResolveICall<FontEngine.get_isProcessingDoneDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_isProcessingDone");
			FontEngine.get_generationProgressDelegateField = IL2CPP.ResolveICall<FontEngine.get_generationProgressDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::get_generationProgress");
			FontEngine.LoadFontFace_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_Internal");
			FontEngine.LoadFontFace_With_Size_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_Internal");
			FontEngine.LoadFontFace_With_Size_And_FaceIndex_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_And_FaceIndex_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_And_FaceIndex_Internal");
			FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal");
			FontEngine.LoadFontFace_FromFont_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_FromFont_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_FromFont_Internal");
			FontEngine.LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal");
			FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_by_FamilyName_and_StyleName_Internal");
			FontEngine.LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal");
			FontEngine.UnloadFontFace_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.UnloadFontFace_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::UnloadFontFace_Internal");
			FontEngine.UnloadAllFontFaces_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.UnloadAllFontFaces_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::UnloadAllFontFaces_Internal");
			FontEngine.GetSystemFontNames_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.GetSystemFontNames_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetSystemFontNames_Internal");
			FontEngine.SetFaceSize_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.SetFaceSize_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetFaceSize_Internal");
			FontEngine.GetFaceCountDelegateField = IL2CPP.ResolveICall<FontEngine.GetFaceCountDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetFaceCount");
			FontEngine.GetFontFaces_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.GetFontFaces_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetFontFaces_Internal");
			FontEngine.TryGetGlyphIndexDelegateField = IL2CPP.ResolveICall<FontEngine.TryGetGlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryGetGlyphIndex");
			FontEngine.LoadGlyph_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.LoadGlyph_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::LoadGlyph_Internal");
			FontEngine.TryPackGlyphInAtlas_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.TryPackGlyphInAtlas_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphInAtlas_Internal");
			FontEngine.TryPackGlyphsInAtlas_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.TryPackGlyphsInAtlas_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryPackGlyphsInAtlas_Internal");
			FontEngine.RenderGlyphsToTexture_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToTexture_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTexture_Internal");
			FontEngine.RenderGlyphsToTextureBuffer_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToTextureBuffer_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToTextureBuffer_Internal");
			FontEngine.RenderGlyphsToSharedTexture_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphsToSharedTexture_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphsToSharedTexture_Internal");
			FontEngine.SetSharedTextureDelegateField = IL2CPP.ResolveICall<FontEngine.SetSharedTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::SetSharedTexture");
			FontEngine.ReleaseSharedTextureDelegateField = IL2CPP.ResolveICall<FontEngine.ReleaseSharedTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::ReleaseSharedTexture");
			FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegateField = IL2CPP.ResolveICall<FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::TryAddGlyphsToTexture_Internal_MultiThread");
			FontEngine.GetOpenTypeFontFeatureTableDelegateField = IL2CPP.ResolveICall<FontEngine.GetOpenTypeFontFeatureTableDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetOpenTypeFontFeatureTable");
			FontEngine.GetGlyphPairAdjustmentTable_InternalDelegateField = IL2CPP.ResolveICall<FontEngine.GetGlyphPairAdjustmentTable_InternalDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetGlyphPairAdjustmentTable_Internal");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes");
			FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField = IL2CPP.ResolveICall<FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex");
			FontEngine.RenderBufferToTextureDelegateField = IL2CPP.ResolveICall<FontEngine.RenderBufferToTextureDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderBufferToTexture");
			FontEngine.RenderGlyphToTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.RenderGlyphToTexture_Internal_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::RenderGlyphToTexture_Internal_Injected");
			FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegateField = IL2CPP.ResolveICall<FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegate>("UnityEngine.TextCore.LowLevel.FontEngine::GetGlyphPairAdjustmentRecord_Injected");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005EB0 File Offset: 0x000040B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89081, RefRangeEnd = 89082, XrefRangeStart = 89076, XrefRangeEnd = 89081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError InitializeFontEngine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005EE0 File Offset: 0x000040E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89082, XrefRangeEnd = 89084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitializeFontEngine_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005F10 File Offset: 0x00004110
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 89089, RefRangeEnd = 89096, XrefRangeStart = 89084, XrefRangeEnd = 89089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontEngineError LoadFontFace(Font font, int pointSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005F60 File Offset: 0x00004160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89096, XrefRangeEnd = 89098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005FB0 File Offset: 0x000041B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89103, RefRangeEnd = 89104, XrefRangeStart = 89098, XrefRangeEnd = 89103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FaceInfo GetFaceInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new FaceInfo(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005FDC File Offset: 0x000041DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89104, XrefRangeEnd = 89106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFaceInfo_Internal(ref FaceInfo faceInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(faceInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006020 File Offset: 0x00004220
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 89108, RefRangeEnd = 89118, XrefRangeStart = 89106, XrefRangeEnd = 89108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetGlyphIndex(uint unicode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006060 File Offset: 0x00004260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89124, RefRangeEnd = 89125, XrefRangeStart = 89118, XrefRangeEnd = 89124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000060D0 File Offset: 0x000042D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89125, XrefRangeEnd = 89127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000612C File Offset: 0x0000432C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89133, RefRangeEnd = 89134, XrefRangeStart = 89127, XrefRangeEnd = 89133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000619C File Offset: 0x0000439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89134, XrefRangeEnd = 89136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphStruct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000061F8 File Offset: 0x000043F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89136, XrefRangeEnd = 89171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyph = ((intPtr4 == 0) ? null : new Glyph(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000062BC File Offset: 0x000044BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89171, XrefRangeEnd = 89173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &freeGlyphRectCount;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &usedGlyphRectCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyph;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*freeGlyphRects = ((intPtr5 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*usedGlyphRects = ((intPtr6 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000063AC File Offset: 0x000045AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 89280, RefRangeEnd = 89283, XrefRangeStart = 89173, XrefRangeEnd = 89280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Il2CppReferenceArray<Glyph> glyphs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			glyphs = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Glyph>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006474 File Offset: 0x00004674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89283, XrefRangeEnd = 89285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryAddGlyphsToTexture_Internal(Il2CppStructArray<uint> glyphIndex, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphs, ref int glyphCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &freeGlyphRectCount;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &usedGlyphRectCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderMode;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &glyphCount;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			*freeGlyphRects = ((intPtr6 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			*usedGlyphRects = ((intPtr7 == 0) ? null : new Il2CppStructArray<GlyphRect>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			*glyphs = ((intPtr8 == 0) ? null : new Il2CppStructArray<GlyphMarshallingStruct>(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006590 File Offset: 0x00004790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89301, RefRangeEnd = 89302, XrefRangeStart = 89285, XrefRangeEnd = 89301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentTable(Il2CppStructArray<uint> glyphIndexes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000065D4 File Offset: 0x000047D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89323, RefRangeEnd = 89324, XrefRangeStart = 89302, XrefRangeEnd = 89323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &recordCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr3) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006628 File Offset: 0x00004828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89324, XrefRangeEnd = 89326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(Il2CppStructArray<uint> glyphIndexes, out int recordCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &recordCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006678 File Offset: 0x00004878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89326, XrefRangeEnd = 89328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] Il2CppStructArray<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_GetGlyphPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*glyphPairAdjustmentRecords = ((intPtr4 == 0) ? null : new Il2CppStructArray<GlyphPairAdjustmentRecord>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000066CC File Offset: 0x000048CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89328, XrefRangeEnd = 89332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref Il2CppArrayBase<T> dstArray)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(srcList);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(dstArray);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FontEngine.MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			srcList = ((intPtr5 == 0) ? null : new List<T>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			dstArray = ((intPtr6 == 0) ? null : new Il2CppArrayBase<T>(intPtr6));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006740 File Offset: 0x00004940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89335, RefRangeEnd = 89337, XrefRangeStart = 89332, XrefRangeEnd = 89335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMarshallingArraySize<T>(ref Il2CppArrayBase<T> marshallingArray, int recordCount)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(marshallingArray);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FontEngine.MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			marshallingArray = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000679C File Offset: 0x0000499C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 89339, RefRangeEnd = 89344, XrefRangeStart = 89337, XrefRangeEnd = 89339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetAtlasTexture(Texture2D texture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontEngine.NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002445 File Offset: 0x00000645
		public FontEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000067D4 File Offset: 0x000049D4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000244E File Offset: 0x0000064E
		public unsafe static Il2CppReferenceArray<Glyph> s_Glyphs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_Glyphs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Glyph>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_Glyphs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000067FC File Offset: 0x000049FC
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002460 File Offset: 0x00000660
		public unsafe static Il2CppStructArray<uint> s_GlyphIndexes_MarshallingArray_A
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006824 File Offset: 0x00004A24
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002472 File Offset: 0x00000672
		public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_IN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000684C File Offset: 0x00004A4C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe static Il2CppStructArray<GlyphMarshallingStruct> s_GlyphMarshallingStruct_OUT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphMarshallingStruct>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00006874 File Offset: 0x00004A74
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002496 File Offset: 0x00000696
		public unsafe static Il2CppStructArray<GlyphRect> s_FreeGlyphRects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_FreeGlyphRects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000689C File Offset: 0x00004A9C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000024A8 File Offset: 0x000006A8
		public unsafe static Il2CppStructArray<GlyphRect> s_UsedGlyphRects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphRect>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_UsedGlyphRects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000068C4 File Offset: 0x00004AC4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000024BA File Offset: 0x000006BA
		public unsafe static Il2CppStructArray<GlyphPairAdjustmentRecord> s_PairAdjustmentRecords_MarshallingArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GlyphPairAdjustmentRecord>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000024CC File Offset: 0x000006CC
		public unsafe static Dictionary<uint, Glyph> s_GlyphLookupDictionary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, Glyph>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontEngine.NativeFieldInfoPtr_s_GlyphLookupDictionary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006914 File Offset: 0x00004B14
		public static FontEngineError DestroyFontEngine()
		{
			return (FontEngineError)FontEngine.DestroyFontEngine_Internal();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000024DE File Offset: 0x000006DE
		public static int DestroyFontEngine_Internal()
		{
			return FontEngine.DestroyFontEngine_InternalDelegateField();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000024EA File Offset: 0x000006EA
		public static void SendCancellationRequest()
		{
			FontEngine.SendCancellationRequest_Internal();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024F3 File Offset: 0x000006F3
		public static void SendCancellationRequest_Internal()
		{
			FontEngine.SendCancellationRequest_InternalDelegateField();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000024FF File Offset: 0x000006FF
		public static bool isProcessingDone
		{
			get
			{
				return FontEngine.get_isProcessingDoneDelegateField();
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000250B File Offset: 0x0000070B
		public static float generationProgress
		{
			get
			{
				return FontEngine.get_generationProgressDelegateField();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000692C File Offset: 0x00004B2C
		public static FontEngineError LoadFontFace(string filePath)
		{
			return (FontEngineError)FontEngine.LoadFontFace_Internal(filePath);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002517 File Offset: 0x00000717
		public static int LoadFontFace_Internal(string filePath)
		{
			return FontEngine.LoadFontFace_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(filePath));
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006944 File Offset: 0x00004B44
		public static FontEngineError LoadFontFace(string filePath, int pointSize)
		{
			return (FontEngineError)FontEngine.LoadFontFace_With_Size_Internal(filePath, pointSize);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002529 File Offset: 0x00000729
		public static int LoadFontFace_With_Size_Internal(string filePath, int pointSize)
		{
			return FontEngine.LoadFontFace_With_Size_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(filePath), pointSize);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006960 File Offset: 0x00004B60
		public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex)
		{
			return (FontEngineError)FontEngine.LoadFontFace_With_Size_And_FaceIndex_Internal(filePath, pointSize, faceIndex);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000253C File Offset: 0x0000073C
		public static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex)
		{
			return FontEngine.LoadFontFace_With_Size_And_FaceIndex_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(filePath), pointSize, faceIndex);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000697C File Offset: 0x00004B7C
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_FromSourceFontFile_Internal(sourceFontFile);
			}
			return fontEngineError;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002550 File Offset: 0x00000750
		public static int LoadFontFace_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile)
		{
			return FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000069A8 File Offset: 0x00004BA8
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, int pointSize)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_With_Size_FromSourceFontFile_Internal(sourceFontFile, pointSize);
			}
			return fontEngineError;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002562 File Offset: 0x00000762
		public static int LoadFontFace_With_Size_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize)
		{
			return FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile), pointSize);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000069D4 File Offset: 0x00004BD4
		public static FontEngineError LoadFontFace(Il2CppStructArray<byte> sourceFontFile, int pointSize, int faceIndex)
		{
			bool flag = sourceFontFile.Length == 0;
			FontEngineError fontEngineError;
			if (flag)
			{
				fontEngineError = FontEngineError.Invalid_File;
			}
			else
			{
				fontEngineError = (FontEngineError)FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(sourceFontFile, pointSize, faceIndex);
			}
			return fontEngineError;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002575 File Offset: 0x00000775
		public static int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_Internal(Il2CppStructArray<byte> sourceFontFile, int pointSize, int faceIndex)
		{
			return FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sourceFontFile), pointSize, faceIndex);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006A00 File Offset: 0x00004C00
		public static FontEngineError LoadFontFace(Font font)
		{
			return (FontEngineError)FontEngine.LoadFontFace_FromFont_Internal(font);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002589 File Offset: 0x00000789
		public static int LoadFontFace_FromFont_Internal(Font font)
		{
			return FontEngine.LoadFontFace_FromFont_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(font));
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006A18 File Offset: 0x00004C18
		public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex)
		{
			return (FontEngineError)FontEngine.LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(font, pointSize, faceIndex);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000259B File Offset: 0x0000079B
		public static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex)
		{
			return FontEngine.LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(font), pointSize, faceIndex);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006A34 File Offset: 0x00004C34
		public static FontEngineError LoadFontFace(string familyName, string styleName)
		{
			return (FontEngineError)FontEngine.LoadFontFace_by_FamilyName_and_StyleName_Internal(familyName, styleName);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000025AF File Offset: 0x000007AF
		public static int LoadFontFace_by_FamilyName_and_StyleName_Internal(string familyName, string styleName)
		{
			return FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(familyName), IL2CPP.ManagedStringToIl2Cpp(styleName));
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006A50 File Offset: 0x00004C50
		public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize)
		{
			return (FontEngineError)FontEngine.LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(familyName, styleName, pointSize);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000025C7 File Offset: 0x000007C7
		public static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize)
		{
			return FontEngine.LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(familyName), IL2CPP.ManagedStringToIl2Cpp(styleName), pointSize);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00006A6C File Offset: 0x00004C6C
		public static FontEngineError UnloadFontFace()
		{
			return (FontEngineError)FontEngine.UnloadFontFace_Internal();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000025E0 File Offset: 0x000007E0
		public static int UnloadFontFace_Internal()
		{
			return FontEngine.UnloadFontFace_InternalDelegateField();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006A84 File Offset: 0x00004C84
		public static FontEngineError UnloadAllFontFaces()
		{
			return (FontEngineError)FontEngine.UnloadAllFontFaces_Internal();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000025EC File Offset: 0x000007EC
		public static int UnloadAllFontFaces_Internal()
		{
			return FontEngine.UnloadAllFontFaces_InternalDelegateField();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006A9C File Offset: 0x00004C9C
		public static Il2CppStringArray GetSystemFontNames()
		{
			Il2CppStringArray systemFontNames_Internal = FontEngine.GetSystemFontNames_Internal();
			bool flag = systemFontNames_Internal != null && systemFontNames_Internal.Length == 0;
			Il2CppStringArray il2CppStringArray;
			if (flag)
			{
				il2CppStringArray = null;
			}
			else
			{
				il2CppStringArray = systemFontNames_Internal;
			}
			return il2CppStringArray;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006ACC File Offset: 0x00004CCC
		public static Il2CppStringArray GetSystemFontNames_Internal()
		{
			IntPtr intPtr = FontEngine.GetSystemFontNames_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public static FontEngineError SetFaceSize(int pointSize)
		{
			return (FontEngineError)FontEngine.SetFaceSize_Internal(pointSize);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000025F8 File Offset: 0x000007F8
		public static int SetFaceSize_Internal(int pointSize)
		{
			return FontEngine.SetFaceSize_InternalDelegateField(pointSize);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002605 File Offset: 0x00000805
		public static int GetFaceCount()
		{
			return FontEngine.GetFaceCountDelegateField();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006B0C File Offset: 0x00004D0C
		public static Il2CppStringArray GetFontFaces()
		{
			Il2CppStringArray fontFaces_Internal = FontEngine.GetFontFaces_Internal();
			bool flag = fontFaces_Internal != null && fontFaces_Internal.Length == 0;
			Il2CppStringArray il2CppStringArray;
			if (flag)
			{
				il2CppStringArray = null;
			}
			else
			{
				il2CppStringArray = fontFaces_Internal;
			}
			return il2CppStringArray;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006B3C File Offset: 0x00004D3C
		public static Il2CppStringArray GetFontFaces_Internal()
		{
			IntPtr intPtr = FontEngine.GetFontFaces_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002611 File Offset: 0x00000811
		public static bool TryGetGlyphIndex(uint unicode, out uint glyphIndex)
		{
			return FontEngine.TryGetGlyphIndexDelegateField(unicode, out glyphIndex);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006B64 File Offset: 0x00004D64
		public static FontEngineError LoadGlyph(uint unicode, GlyphLoadFlags flags)
		{
			return (FontEngineError)FontEngine.LoadGlyph_Internal(unicode, flags);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000261F File Offset: 0x0000081F
		public static int LoadGlyph_Internal(uint unicode, GlyphLoadFlags loadFlags)
		{
			return FontEngine.LoadGlyph_InternalDelegateField(unicode, loadFlags);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000262D File Offset: 0x0000082D
		public static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006B80 File Offset: 0x00004D80
		public static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
		{
			return FontEngine.TryPackGlyphInAtlas_InternalDelegateField(ref glyph, padding, packingMode, renderMode, width, height, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000263A File Offset: 0x0000083A
		public static bool TryPackGlyphsInAtlas(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public static bool TryPackGlyphsInAtlas_Internal([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount)
		{
			return FontEngine.TryPackGlyphsInAtlas_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphsToAdd), ref glyphsToAddCount, IL2CPP.Il2CppObjectBaseToPtr(glyphsAdded), ref glyphsAddedCount, padding, packingMode, renderMode, width, height, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006BF8 File Offset: 0x00004DF8
		public static FontEngineError RenderGlyphToTexture(Glyph glyph, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			GlyphMarshallingStruct glyphMarshallingStruct = new GlyphMarshallingStruct(glyph);
			return (FontEngineError)FontEngine.RenderGlyphToTexture_Internal(glyphMarshallingStruct, padding, renderMode, texture);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002647 File Offset: 0x00000847
		public static int RenderGlyphToTexture_Internal(GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphToTexture_Internal_Injected(ref glyphStruct, padding, renderMode, texture);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002653 File Offset: 0x00000853
		public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002660 File Offset: 0x00000860
		public static int RenderGlyphsToTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphsToTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000267C File Offset: 0x0000087C
		public static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002689 File Offset: 0x00000889
		public static int RenderGlyphsToTextureBuffer_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] Il2CppStructArray<byte> texBuffer, int texWidth, int texHeight)
		{
			return FontEngine.RenderGlyphsToTextureBuffer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texBuffer), texWidth, texHeight);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000026A9 File Offset: 0x000008A9
		public static FontEngineError RenderGlyphsToSharedTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000026B6 File Offset: 0x000008B6
		public static int RenderGlyphsToSharedTexture_Internal(Il2CppStructArray<GlyphMarshallingStruct> glyphs, int glyphCount, int padding, GlyphRenderMode renderMode)
		{
			return FontEngine.RenderGlyphsToSharedTexture_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphs), glyphCount, padding, renderMode);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000026CB File Offset: 0x000008CB
		public static void SetSharedTexture(Texture2D texture)
		{
			FontEngine.SetSharedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000026DD File Offset: 0x000008DD
		public static void ReleaseSharedTexture()
		{
			FontEngine.ReleaseSharedTextureDelegateField();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000026E9 File Offset: 0x000008E9
		public static bool TryAddGlyphsToTexture(List<Glyph> glyphsToAdd, List<Glyph> glyphsAdded, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006C1C File Offset: 0x00004E1C
		public static bool TryAddGlyphsToTexture_Internal_MultiThread([Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsToAdd, ref int glyphsToAddCount, [Out] Il2CppStructArray<GlyphMarshallingStruct> glyphsAdded, ref int glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] Il2CppStructArray<GlyphRect> freeGlyphRects, ref int freeGlyphRectCount, [Out] Il2CppStructArray<GlyphRect> usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphsToAdd), ref glyphsToAddCount, IL2CPP.Il2CppObjectBaseToPtr(glyphsAdded), ref glyphsAddedCount, padding, packingMode, IL2CPP.Il2CppObjectBaseToPtr(freeGlyphRects), ref freeGlyphRectCount, IL2CPP.Il2CppObjectBaseToPtr(usedGlyphRects), ref usedGlyphRectCount, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000026F6 File Offset: 0x000008F6
		public static int GetOpenTypeFontFeatureTable()
		{
			return FontEngine.GetOpenTypeFontFeatureTableDelegateField();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002702 File Offset: 0x00000902
		public static int GetGlyphPairAdjustmentTable_Internal(Il2CppStructArray<uint> glyphIndexes, [Out] Il2CppStructArray<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords, out int adjustmentRecordCount)
		{
			return FontEngine.GetGlyphPairAdjustmentTable_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(glyphIndexes), IL2CPP.Il2CppObjectBaseToPtr(glyphPairAdjustmentRecords), out adjustmentRecordCount);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006C60 File Offset: 0x00004E60
		public static GlyphPairAdjustmentRecord GetGlyphPairAdjustmentRecord(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			GlyphPairAdjustmentRecord glyphPairAdjustmentRecord;
			FontEngine.GetGlyphPairAdjustmentRecord_Injected(firstGlyphIndex, secondGlyphIndex, out glyphPairAdjustmentRecord);
			return glyphPairAdjustmentRecord;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000271B File Offset: 0x0000091B
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002728 File Offset: 0x00000928
		public static Il2CppStructArray<GlyphPairAdjustmentRecord> GetGlyphPairAdjustmentRecords(uint glyphIndex, out int recordCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002735 File Offset: 0x00000935
		public static int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexes(Il2CppStructArray<uint> newGlyphIndexes, Il2CppStructArray<uint> allGlyphIndexes, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(newGlyphIndexes), IL2CPP.Il2CppObjectBaseToPtr(allGlyphIndexes), out recordCount);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000274E File Offset: 0x0000094E
		public static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndex(uint glyphIndex, out int recordCount)
		{
			return FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField(glyphIndex, out recordCount);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000275C File Offset: 0x0000095C
		public static void RenderBufferToTexture(Texture2D srcTexture, int padding, GlyphRenderMode renderMode, Texture2D dstTexture)
		{
			FontEngine.RenderBufferToTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(srcTexture), padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(dstTexture));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002776 File Offset: 0x00000976
		public static int RenderGlyphToTexture_Internal_Injected(ref GlyphMarshallingStruct glyphStruct, int padding, GlyphRenderMode renderMode, Texture2D texture)
		{
			return FontEngine.RenderGlyphToTexture_Internal_InjectedDelegateField(ref glyphStruct, padding, renderMode, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000278B File Offset: 0x0000098B
		public static void GetGlyphPairAdjustmentRecord_Injected(uint firstGlyphIndex, uint secondGlyphIndex, out GlyphPairAdjustmentRecord ret)
		{
			FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegateField(firstGlyphIndex, secondGlyphIndex, out ret);
		}

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_s_Glyphs;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphIndexes_MarshallingArray_A;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_IN;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphMarshallingStruct_OUT;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_s_FreeGlyphRects;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_s_UsedGlyphRects;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_s_PairAdjustmentRecords_MarshallingArray;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_s_GlyphLookupDictionary;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFontEngine_Public_Static_FontEngineError_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFontEngine_Internal_Private_Static_Int32_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_Public_Static_FontEngineError_Font_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontFace_With_Size_FromFont_Internal_Private_Static_Int32_Font_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceInfo_Public_Static_FaceInfo_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_GetFaceInfo_Internal_Private_Static_Int32_byref_FaceInfo_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphIndex_Internal_Static_UInt32_UInt32_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithUnicodeValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Public_Static_Boolean_UInt32_GlyphLoadFlags_byref_Glyph_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_TryGetGlyphWithIndexValue_Internal_Private_Static_Boolean_UInt32_GlyphLoadFlags_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Static_Boolean_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Glyph_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphToTexture_Internal_Private_Static_Boolean_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_byref_GlyphMarshallingStruct_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Static_Boolean_List_1_UInt32_Int32_GlyphPackingMode_List_1_GlyphRect_List_1_GlyphRect_GlyphRenderMode_Texture2D_byref_Il2CppReferenceArray_1_Glyph_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_TryAddGlyphsToTexture_Internal_Private_Static_Boolean_Il2CppStructArray_1_UInt32_Int32_GlyphPackingMode_Il2CppStructArray_1_GlyphRect_byref_Int32_Il2CppStructArray_1_GlyphRect_byref_Int32_GlyphRenderMode_Texture2D_Il2CppStructArray_1_GlyphMarshallingStruct_byref_Int32_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentTable_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_Il2CppStructArray_1_UInt32_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentRecords_Internal_Static_Il2CppStructArray_1_GlyphPairAdjustmentRecord_List_1_UInt32_byref_Int32_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes_Private_Static_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphPairAdjustmentRecordsFromMarshallingArray_Private_Static_Int32_Il2CppStructArray_1_GlyphPairAdjustmentRecord_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_ResetAtlasTexture_Internal_Static_Void_Texture2D_0;

		// Token: 0x040000D9 RID: 217
		private static readonly FontEngine.DestroyFontEngine_InternalDelegate DestroyFontEngine_InternalDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly FontEngine.SendCancellationRequest_InternalDelegate SendCancellationRequest_InternalDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly FontEngine.get_isProcessingDoneDelegate get_isProcessingDoneDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly FontEngine.get_generationProgressDelegate get_generationProgressDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly FontEngine.LoadFontFace_InternalDelegate LoadFontFace_InternalDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly FontEngine.LoadFontFace_With_Size_InternalDelegate LoadFontFace_With_Size_InternalDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly FontEngine.LoadFontFace_With_Size_And_FaceIndex_InternalDelegate LoadFontFace_With_Size_And_FaceIndex_InternalDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly FontEngine.LoadFontFace_FromSourceFontFile_InternalDelegate LoadFontFace_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly FontEngine.LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate LoadFontFace_With_Size_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly FontEngine.LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly FontEngine.LoadFontFace_FromFont_InternalDelegate LoadFontFace_FromFont_InternalDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly FontEngine.LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegate LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly FontEngine.LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate LoadFontFace_by_FamilyName_and_StyleName_InternalDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly FontEngine.LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegate LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly FontEngine.UnloadFontFace_InternalDelegate UnloadFontFace_InternalDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly FontEngine.UnloadAllFontFaces_InternalDelegate UnloadAllFontFaces_InternalDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly FontEngine.GetSystemFontNames_InternalDelegate GetSystemFontNames_InternalDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly FontEngine.SetFaceSize_InternalDelegate SetFaceSize_InternalDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly FontEngine.GetFaceCountDelegate GetFaceCountDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly FontEngine.GetFontFaces_InternalDelegate GetFontFaces_InternalDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly FontEngine.TryGetGlyphIndexDelegate TryGetGlyphIndexDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly FontEngine.LoadGlyph_InternalDelegate LoadGlyph_InternalDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly FontEngine.TryPackGlyphInAtlas_InternalDelegate TryPackGlyphInAtlas_InternalDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly FontEngine.TryPackGlyphsInAtlas_InternalDelegate TryPackGlyphsInAtlas_InternalDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly FontEngine.RenderGlyphsToTexture_InternalDelegate RenderGlyphsToTexture_InternalDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly FontEngine.RenderGlyphsToTextureBuffer_InternalDelegate RenderGlyphsToTextureBuffer_InternalDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly FontEngine.RenderGlyphsToSharedTexture_InternalDelegate RenderGlyphsToSharedTexture_InternalDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly FontEngine.SetSharedTextureDelegate SetSharedTextureDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly FontEngine.ReleaseSharedTextureDelegate ReleaseSharedTextureDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly FontEngine.TryAddGlyphsToTexture_Internal_MultiThreadDelegate TryAddGlyphsToTexture_Internal_MultiThreadDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly FontEngine.GetOpenTypeFontFeatureTableDelegate GetOpenTypeFontFeatureTableDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly FontEngine.GetGlyphPairAdjustmentTable_InternalDelegate GetGlyphPairAdjustmentTable_InternalDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly FontEngine.PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly FontEngine.RenderBufferToTextureDelegate RenderBufferToTextureDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly FontEngine.RenderGlyphToTexture_Internal_InjectedDelegate RenderGlyphToTexture_Internal_InjectedDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly FontEngine.GetGlyphPairAdjustmentRecord_InjectedDelegate GetGlyphPairAdjustmentRecord_InjectedDelegateField;

		// Token: 0x0200003B RID: 59
		private sealed class MethodInfoStoreGeneric_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x0400025E RID: 606
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FontEngine.NativeMethodInfoPtr_GenericListToMarshallingArray_Private_Static_Void_byref_List_1_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400025F RID: 607
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FontEngine.NativeMethodInfoPtr_SetMarshallingArraySize_Private_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<FontEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000235 RID: 565
		private delegate int DestroyFontEngine_InternalDelegate();

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000237 RID: 567
		private delegate void SendCancellationRequest_InternalDelegate();

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000239 RID: 569
		private delegate bool get_isProcessingDoneDelegate();

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600023B RID: 571
		private delegate float get_generationProgressDelegate();

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600023D RID: 573
		private delegate int LoadFontFace_InternalDelegate(IntPtr filePath);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600023F RID: 575
		private delegate int LoadFontFace_With_Size_InternalDelegate(IntPtr filePath, int pointSize);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000241 RID: 577
		private delegate int LoadFontFace_With_Size_And_FaceIndex_InternalDelegate(IntPtr filePath, int pointSize, int faceIndex);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000243 RID: 579
		private delegate int LoadFontFace_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000245 RID: 581
		private delegate int LoadFontFace_With_Size_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile, int pointSize);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000247 RID: 583
		private delegate int LoadFontFace_With_Size_And_FaceIndex_FromSourceFontFile_InternalDelegate(IntPtr sourceFontFile, int pointSize, int faceIndex);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000249 RID: 585
		private delegate int LoadFontFace_FromFont_InternalDelegate(IntPtr font);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600024B RID: 587
		private delegate int LoadFontFace_With_Size_and_FaceIndex_FromFont_InternalDelegate(IntPtr font, int pointSize, int faceIndex);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600024D RID: 589
		private delegate int LoadFontFace_by_FamilyName_and_StyleName_InternalDelegate(IntPtr familyName, IntPtr styleName);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600024F RID: 591
		private delegate int LoadFontFace_With_Size_by_FamilyName_and_StyleName_InternalDelegate(IntPtr familyName, IntPtr styleName, int pointSize);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000251 RID: 593
		private delegate int UnloadFontFace_InternalDelegate();

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000253 RID: 595
		private delegate int UnloadAllFontFaces_InternalDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000255 RID: 597
		private delegate IntPtr GetSystemFontNames_InternalDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000257 RID: 599
		private delegate int SetFaceSize_InternalDelegate(int pointSize);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000259 RID: 601
		private delegate int GetFaceCountDelegate();

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600025B RID: 603
		private delegate IntPtr GetFontFaces_InternalDelegate();

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600025D RID: 605
		private delegate bool TryGetGlyphIndexDelegate(uint unicode, [Out] IntPtr glyphIndex);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600025F RID: 607
		private delegate int LoadGlyph_InternalDelegate(uint unicode, GlyphLoadFlags loadFlags);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate bool TryPackGlyphInAtlas_InternalDelegate(IntPtr glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate bool TryPackGlyphsInAtlas_InternalDelegate([Out] IntPtr glyphsToAdd, IntPtr glyphsToAddCount, [Out] IntPtr glyphsAdded, IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate int RenderGlyphsToTexture_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate int RenderGlyphsToTextureBuffer_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, [Out] IntPtr texBuffer, int texWidth, int texHeight);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate int RenderGlyphsToSharedTexture_InternalDelegate(IntPtr glyphs, int glyphCount, int padding, GlyphRenderMode renderMode);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate void SetSharedTextureDelegate(IntPtr texture);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate void ReleaseSharedTextureDelegate();

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate bool TryAddGlyphsToTexture_Internal_MultiThreadDelegate([Out] IntPtr glyphsToAdd, IntPtr glyphsToAddCount, [Out] IntPtr glyphsAdded, IntPtr glyphsAddedCount, int padding, GlyphPackingMode packingMode, [Out] IntPtr freeGlyphRects, IntPtr freeGlyphRectCount, [Out] IntPtr usedGlyphRects, IntPtr usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate int GetOpenTypeFontFeatureTableDelegate();

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate int GetGlyphPairAdjustmentTable_InternalDelegate(IntPtr glyphIndexes, [Out] IntPtr glyphPairAdjustmentRecords, [Out] IntPtr adjustmentRecordCount);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate int PopulatePairAdjustmentRecordMarshallingArray_for_NewlyAddedGlyphIndexesDelegate(IntPtr newGlyphIndexes, IntPtr allGlyphIndexes, [Out] IntPtr recordCount);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexDelegate(uint glyphIndex, [Out] IntPtr recordCount);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate void RenderBufferToTextureDelegate(IntPtr srcTexture, int padding, GlyphRenderMode renderMode, IntPtr dstTexture);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate int RenderGlyphToTexture_Internal_InjectedDelegate(IntPtr glyphStruct, int padding, GlyphRenderMode renderMode, IntPtr texture);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate void GetGlyphPairAdjustmentRecord_InjectedDelegate(uint firstGlyphIndex, uint secondGlyphIndex, [Out] IntPtr ret);
	}
}
