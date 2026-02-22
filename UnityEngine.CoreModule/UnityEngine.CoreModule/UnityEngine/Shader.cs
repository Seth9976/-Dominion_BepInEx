using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000055 RID: 85
	public sealed class Shader : Object
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x000261F8 File Offset: 0x000243F8
		// Note: this type is marked as 'beforefieldinit'.
		static Shader()
		{
			Il2CppClassPointerStore<Shader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Shader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shader>.NativeClassPtr);
			Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663641);
			Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663642);
			Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663643);
			Shader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100663644);
			Shader.FindBuiltinDelegateField = IL2CPP.ResolveICall<Shader.FindBuiltinDelegate>("UnityEngine.Shader::FindBuiltin");
			Shader.get_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_maximumLODDelegate>("UnityEngine.Shader::get_maximumLOD");
			Shader.set_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_maximumLODDelegate>("UnityEngine.Shader::set_maximumLOD");
			Shader.get_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_globalMaximumLODDelegate>("UnityEngine.Shader::get_globalMaximumLOD");
			Shader.set_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_globalMaximumLODDelegate>("UnityEngine.Shader::set_globalMaximumLOD");
			Shader.get_isSupportedDelegateField = IL2CPP.ResolveICall<Shader.get_isSupportedDelegate>("UnityEngine.Shader::get_isSupported");
			Shader.get_globalRenderPipelineDelegateField = IL2CPP.ResolveICall<Shader.get_globalRenderPipelineDelegate>("UnityEngine.Shader::get_globalRenderPipeline");
			Shader.set_globalRenderPipelineDelegateField = IL2CPP.ResolveICall<Shader.set_globalRenderPipelineDelegate>("UnityEngine.Shader::set_globalRenderPipeline");
			Shader.EnableKeywordDelegateField = IL2CPP.ResolveICall<Shader.EnableKeywordDelegate>("UnityEngine.Shader::EnableKeyword");
			Shader.DisableKeywordDelegateField = IL2CPP.ResolveICall<Shader.DisableKeywordDelegate>("UnityEngine.Shader::DisableKeyword");
			Shader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<Shader.IsKeywordEnabledDelegate>("UnityEngine.Shader::IsKeywordEnabled");
			Shader.get_renderQueueDelegateField = IL2CPP.ResolveICall<Shader.get_renderQueueDelegate>("UnityEngine.Shader::get_renderQueue");
			Shader.get_disableBatchingDelegateField = IL2CPP.ResolveICall<Shader.get_disableBatchingDelegate>("UnityEngine.Shader::get_disableBatching");
			Shader.WarmupAllShadersDelegateField = IL2CPP.ResolveICall<Shader.WarmupAllShadersDelegate>("UnityEngine.Shader::WarmupAllShaders");
			Shader.IDToTagDelegateField = IL2CPP.ResolveICall<Shader.IDToTagDelegate>("UnityEngine.Shader::IDToTag");
			Shader.GetDependencyDelegateField = IL2CPP.ResolveICall<Shader.GetDependencyDelegate>("UnityEngine.Shader::GetDependency");
			Shader.get_passCountDelegateField = IL2CPP.ResolveICall<Shader.get_passCountDelegate>("UnityEngine.Shader::get_passCount");
			Shader.Internal_FindPassTagValueDelegateField = IL2CPP.ResolveICall<Shader.Internal_FindPassTagValueDelegate>("UnityEngine.Shader::Internal_FindPassTagValue");
			Shader.SetGlobalIntImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalIntImplDelegate>("UnityEngine.Shader::SetGlobalIntImpl");
			Shader.SetGlobalFloatImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalFloatImplDelegate>("UnityEngine.Shader::SetGlobalFloatImpl");
			Shader.SetGlobalTextureImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalTextureImplDelegate>("UnityEngine.Shader::SetGlobalTextureImpl");
			Shader.SetGlobalRenderTextureImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalRenderTextureImplDelegate>("UnityEngine.Shader::SetGlobalRenderTextureImpl");
			Shader.SetGlobalBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalBufferImplDelegate>("UnityEngine.Shader::SetGlobalBufferImpl");
			Shader.SetGlobalGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalGraphicsBufferImpl");
			Shader.SetGlobalConstantBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalConstantBufferImplDelegate>("UnityEngine.Shader::SetGlobalConstantBufferImpl");
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalConstantGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalConstantGraphicsBufferImpl");
			Shader.GetGlobalIntImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalIntImplDelegate>("UnityEngine.Shader::GetGlobalIntImpl");
			Shader.GetGlobalFloatImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatImplDelegate>("UnityEngine.Shader::GetGlobalFloatImpl");
			Shader.GetGlobalTextureImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalTextureImplDelegate>("UnityEngine.Shader::GetGlobalTextureImpl");
			Shader.SetGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalFloatArrayImplDelegate>("UnityEngine.Shader::SetGlobalFloatArrayImpl");
			Shader.SetGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalVectorArrayImplDelegate>("UnityEngine.Shader::SetGlobalVectorArrayImpl");
			Shader.SetGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::SetGlobalMatrixArrayImpl");
			Shader.GetGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayImpl");
			Shader.GetGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayImpl");
			Shader.GetGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayImpl");
			Shader.GetGlobalFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayCountImpl");
			Shader.GetGlobalVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayCountImpl");
			Shader.GetGlobalMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayCountImpl");
			Shader.ExtractGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalFloatArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalFloatArrayImpl");
			Shader.ExtractGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalVectorArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalVectorArrayImpl");
			Shader.ExtractGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalMatrixArrayImpl");
			Shader.GetPropertyNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameDelegate>("UnityEngine.Shader::GetPropertyName");
			Shader.GetPropertyNameIdDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameIdDelegate>("UnityEngine.Shader::GetPropertyNameId");
			Shader.GetPropertyTypeDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTypeDelegate>("UnityEngine.Shader::GetPropertyType");
			Shader.GetPropertyDescriptionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDescriptionDelegate>("UnityEngine.Shader::GetPropertyDescription");
			Shader.GetPropertyFlagsDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyFlagsDelegate>("UnityEngine.Shader::GetPropertyFlags");
			Shader.GetPropertyAttributesDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyAttributesDelegate>("UnityEngine.Shader::GetPropertyAttributes");
			Shader.GetPropertyDefaultIntValueDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDefaultIntValueDelegate>("UnityEngine.Shader::GetPropertyDefaultIntValue");
			Shader.GetPropertyTextureDimensionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDimensionDelegate>("UnityEngine.Shader::GetPropertyTextureDimension");
			Shader.GetPropertyTextureDefaultNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDefaultNameDelegate>("UnityEngine.Shader::GetPropertyTextureDefaultName");
			Shader.FindTextureStackImplDelegateField = IL2CPP.ResolveICall<Shader.FindTextureStackImplDelegate>("UnityEngine.Shader::FindTextureStackImpl");
			Shader.GetPropertyCountDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyCountDelegate>("UnityEngine.Shader::GetPropertyCount");
			Shader.FindPropertyIndexDelegateField = IL2CPP.ResolveICall<Shader.FindPropertyIndexDelegate>("UnityEngine.Shader::FindPropertyIndex");
			Shader.SetGlobalVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalVectorImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalVectorImpl_Injected");
			Shader.SetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalMatrixImpl_Injected");
			Shader.GetGlobalVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalVectorImpl_Injected");
			Shader.GetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalMatrixImpl_Injected");
			Shader.GetPropertyDefaultValue_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDefaultValue_InjectedDelegate>("UnityEngine.Shader::GetPropertyDefaultValue_Injected");
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000265E0 File Offset: 0x000247E0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 62915, RefRangeEnd = 62931, XrefRangeStart = 62910, XrefRangeEnd = 62915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader Find(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00026624 File Offset: 0x00024824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62931, XrefRangeEnd = 62933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TagToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00026668 File Offset: 0x00024868
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 62935, RefRangeEnd = 63005, XrefRangeStart = 62933, XrefRangeEnd = 62935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropertyToID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000266AC File Offset: 0x000248AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63005, XrefRangeEnd = 63009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00006209 File Offset: 0x00004409
		public Shader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x000266E8 File Offset: 0x000248E8
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00006212 File Offset: 0x00004412
		public static UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		{
			get
			{
				return (UnityEngine.Rendering.ShaderHardwareTier)Graphics.activeTier;
			}
			set
			{
				Graphics.activeTier = (UnityEngine.Rendering.GraphicsTier)value;
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00026700 File Offset: 0x00024900
		public static Shader FindBuiltin(string name)
		{
			IntPtr intPtr = Shader.FindBuiltinDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0000621C File Offset: 0x0000441C
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0000622E File Offset: 0x0000442E
		public int maximumLOD
		{
			get
			{
				return Shader.get_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Shader.set_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00006241 File Offset: 0x00004441
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0000624D File Offset: 0x0000444D
		public static int globalMaximumLOD
		{
			get
			{
				return Shader.get_globalMaximumLODDelegateField();
			}
			set
			{
				Shader.set_globalMaximumLODDelegateField(value);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0000625A File Offset: 0x0000445A
		public bool isSupported
		{
			get
			{
				return Shader.get_isSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0002672C File Offset: 0x0002492C
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x0000626C File Offset: 0x0000446C
		public static string globalRenderPipeline
		{
			get
			{
				IntPtr intPtr = Shader.get_globalRenderPipelineDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Shader.set_globalRenderPipelineDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0000627E File Offset: 0x0000447E
		public static void EnableKeyword(string keyword)
		{
			Shader.EnableKeywordDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00006290 File Offset: 0x00004490
		public static void DisableKeyword(string keyword)
		{
			Shader.DisableKeywordDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000062A2 File Offset: 0x000044A2
		public static bool IsKeywordEnabled(string keyword)
		{
			return Shader.IsKeywordEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000062B4 File Offset: 0x000044B4
		public int renderQueue
		{
			get
			{
				return Shader.get_renderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000062C6 File Offset: 0x000044C6
		public DisableBatchingType disableBatching
		{
			get
			{
				return Shader.get_disableBatchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000062D8 File Offset: 0x000044D8
		public static void WarmupAllShaders()
		{
			Shader.WarmupAllShadersDelegateField();
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0002674C File Offset: 0x0002494C
		public static string IDToTag(int name)
		{
			IntPtr intPtr = Shader.IDToTagDelegateField(name);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0002676C File Offset: 0x0002496C
		public Shader GetDependency(string name)
		{
			IntPtr intPtr = Shader.GetDependencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x000062E4 File Offset: 0x000044E4
		public int passCount
		{
			get
			{
				return Shader.get_passCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000267A0 File Offset: 0x000249A0
		public UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			bool flag = passIndex < 0 || passIndex >= this.passCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("passIndex");
			}
			int num = this.Internal_FindPassTagValue(passIndex, tagName.id);
			return new UnityEngine.Rendering.ShaderTagId
			{
				id = num
			};
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000062F6 File Offset: 0x000044F6
		public int Internal_FindPassTagValue(int passIndex, int tagName)
		{
			return Shader.Internal_FindPassTagValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), passIndex, tagName);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000630A File Offset: 0x0000450A
		public static void SetGlobalIntImpl(int name, int value)
		{
			Shader.SetGlobalIntImplDelegateField(name, value);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00006318 File Offset: 0x00004518
		public static void SetGlobalFloatImpl(int name, float value)
		{
			Shader.SetGlobalFloatImplDelegateField(name, value);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00006326 File Offset: 0x00004526
		public static void SetGlobalVectorImpl(int name, Vector4 value)
		{
			Shader.SetGlobalVectorImpl_Injected(name, ref value);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00006330 File Offset: 0x00004530
		public static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_Injected(name, ref value);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000633A File Offset: 0x0000453A
		public static void SetGlobalTextureImpl(int name, Texture value)
		{
			Shader.SetGlobalTextureImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000634D File Offset: 0x0000454D
		public static void SetGlobalRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00006361 File Offset: 0x00004561
		public static void SetGlobalBufferImpl(int name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00006374 File Offset: 0x00004574
		public static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00006387 File Offset: 0x00004587
		public static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000639C File Offset: 0x0000459C
		public static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000063B1 File Offset: 0x000045B1
		public static int GetGlobalIntImpl(int name)
		{
			return Shader.GetGlobalIntImplDelegateField(name);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000063BE File Offset: 0x000045BE
		public static float GetGlobalFloatImpl(int name)
		{
			return Shader.GetGlobalFloatImplDelegateField(name);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000267F8 File Offset: 0x000249F8
		public static Vector4 GetGlobalVectorImpl(int name)
		{
			Vector4 vector;
			Shader.GetGlobalVectorImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00026810 File Offset: 0x00024A10
		public static Matrix4x4 GetGlobalMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			Shader.GetGlobalMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00026828 File Offset: 0x00024A28
		public static Texture GetGlobalTextureImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalTextureImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000063CB File Offset: 0x000045CB
		public static void SetGlobalFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			Shader.SetGlobalFloatArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000063DF File Offset: 0x000045DF
		public static void SetGlobalVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			Shader.SetGlobalVectorArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000063F3 File Offset: 0x000045F3
		public static void SetGlobalMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			Shader.SetGlobalMatrixArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00026850 File Offset: 0x00024A50
		public static Il2CppStructArray<float> GetGlobalFloatArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalFloatArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00026878 File Offset: 0x00024A78
		public static Il2CppStructArray<Vector4> GetGlobalVectorArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalVectorArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000268A0 File Offset: 0x00024AA0
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalMatrixArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00006407 File Offset: 0x00004607
		public static int GetGlobalFloatArrayCountImpl(int name)
		{
			return Shader.GetGlobalFloatArrayCountImplDelegateField(name);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00006414 File Offset: 0x00004614
		public static int GetGlobalVectorArrayCountImpl(int name)
		{
			return Shader.GetGlobalVectorArrayCountImplDelegateField(name);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00006421 File Offset: 0x00004621
		public static int GetGlobalMatrixArrayCountImpl(int name)
		{
			return Shader.GetGlobalMatrixArrayCountImplDelegateField(name);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000642E File Offset: 0x0000462E
		public static void ExtractGlobalFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Shader.ExtractGlobalFloatArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00006441 File Offset: 0x00004641
		public static void ExtractGlobalVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Shader.ExtractGlobalVectorArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00006454 File Offset: 0x00004654
		public static void ExtractGlobalMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Shader.ExtractGlobalMatrixArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000268C8 File Offset: 0x00024AC8
		public static void SetGlobalFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			Shader.SetGlobalFloatArrayImpl(name, values, count);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00026924 File Offset: 0x00024B24
		public static void SetGlobalVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			Shader.SetGlobalVectorArrayImpl(name, values, count);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00026980 File Offset: 0x00024B80
		public static void SetGlobalMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			Shader.SetGlobalMatrixArrayImpl(name, values, count);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000269DC File Offset: 0x00024BDC
		public static void ExtractGlobalFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalFloatArrayCountImpl = Shader.GetGlobalFloatArrayCountImpl(name);
			bool flag2 = globalFloatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, globalFloatArrayCountImpl);
				Shader.ExtractGlobalFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00026A30 File Offset: 0x00024C30
		public static void ExtractGlobalVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalVectorArrayCountImpl = Shader.GetGlobalVectorArrayCountImpl(name);
			bool flag2 = globalVectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, globalVectorArrayCountImpl);
				Shader.ExtractGlobalVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00026A84 File Offset: 0x00024C84
		public static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalMatrixArrayCountImpl = Shader.GetGlobalMatrixArrayCountImpl(name);
			bool flag2 = globalMatrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, globalMatrixArrayCountImpl);
				Shader.ExtractGlobalMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00006467 File Offset: 0x00004667
		public static void SetGlobalInt(string name, int value)
		{
			Shader.SetGlobalFloatImpl(Shader.PropertyToID(name), (float)value);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00006478 File Offset: 0x00004678
		public static void SetGlobalInt(int nameID, int value)
		{
			Shader.SetGlobalFloatImpl(nameID, (float)value);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00006484 File Offset: 0x00004684
		public static void SetGlobalFloat(string name, float value)
		{
			Shader.SetGlobalFloatImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00006494 File Offset: 0x00004694
		public static void SetGlobalFloat(int nameID, float value)
		{
			Shader.SetGlobalFloatImpl(nameID, value);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000649F File Offset: 0x0000469F
		public static void SetGlobalInteger(string name, int value)
		{
			Shader.SetGlobalIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000064AF File Offset: 0x000046AF
		public static void SetGlobalInteger(int nameID, int value)
		{
			Shader.SetGlobalIntImpl(nameID, value);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000064BA File Offset: 0x000046BA
		public static void SetGlobalVector(string name, Vector4 value)
		{
			Shader.SetGlobalVectorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000064CA File Offset: 0x000046CA
		public static void SetGlobalVector(int nameID, Vector4 value)
		{
			Shader.SetGlobalVectorImpl(nameID, value);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000064D5 File Offset: 0x000046D5
		public static void SetGlobalColor(string name, Color value)
		{
			Shader.SetGlobalVectorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000064EA File Offset: 0x000046EA
		public static void SetGlobalColor(int nameID, Color value)
		{
			Shader.SetGlobalVectorImpl(nameID, value);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000064FA File Offset: 0x000046FA
		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000650A File Offset: 0x0000470A
		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(nameID, value);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00006515 File Offset: 0x00004715
		public static void SetGlobalTexture(string name, Texture value)
		{
			Shader.SetGlobalTextureImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00006525 File Offset: 0x00004725
		public static void SetGlobalTexture(int nameID, Texture value)
		{
			Shader.SetGlobalTextureImpl(nameID, value);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00006530 File Offset: 0x00004730
		public static void SetGlobalTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00006541 File Offset: 0x00004741
		public static void SetGlobalTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000654D File Offset: 0x0000474D
		public static void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000655D File Offset: 0x0000475D
		public static void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(nameID, value);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00006568 File Offset: 0x00004768
		public static void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00006578 File Offset: 0x00004778
		public static void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00006583 File Offset: 0x00004783
		public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00006595 File Offset: 0x00004795
		public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000065A2 File Offset: 0x000047A2
		public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000065B4 File Offset: 0x000047B4
		public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000065C1 File Offset: 0x000047C1
		public static void SetGlobalFloatArray(string name, List<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000065DC File Offset: 0x000047DC
		public static void SetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000065F2 File Offset: 0x000047F2
		public static void SetGlobalFloatArray(string name, Il2CppStructArray<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00006609 File Offset: 0x00004809
		public static void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000661B File Offset: 0x0000481B
		public static void SetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00006636 File Offset: 0x00004836
		public static void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000664C File Offset: 0x0000484C
		public static void SetGlobalVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00006663 File Offset: 0x00004863
		public static void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, values, values.Length);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00006675 File Offset: 0x00004875
		public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00006690 File Offset: 0x00004890
		public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000066A6 File Offset: 0x000048A6
		public static void SetGlobalMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000066BD File Offset: 0x000048BD
		public static void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00026AD8 File Offset: 0x00024CD8
		public static int GetGlobalInt(string name)
		{
			return (int)Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00026AF8 File Offset: 0x00024CF8
		public static int GetGlobalInt(int nameID)
		{
			return (int)Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00026B14 File Offset: 0x00024D14
		public static float GetGlobalFloat(string name)
		{
			return Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00026B34 File Offset: 0x00024D34
		public static float GetGlobalFloat(int nameID)
		{
			return Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00026B4C File Offset: 0x00024D4C
		public static int GetGlobalInteger(string name)
		{
			return Shader.GetGlobalIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00026B6C File Offset: 0x00024D6C
		public static int GetGlobalInteger(int nameID)
		{
			return Shader.GetGlobalIntImpl(nameID);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00026B84 File Offset: 0x00024D84
		public static Vector4 GetGlobalVector(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00026BA4 File Offset: 0x00024DA4
		public static Vector4 GetGlobalVector(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00026BBC File Offset: 0x00024DBC
		public static Color GetGlobalColor(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00026BE0 File Offset: 0x00024DE0
		public static Color GetGlobalColor(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00026C00 File Offset: 0x00024E00
		public static Matrix4x4 GetGlobalMatrix(string name)
		{
			return Shader.GetGlobalMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00026C20 File Offset: 0x00024E20
		public static Matrix4x4 GetGlobalMatrix(int nameID)
		{
			return Shader.GetGlobalMatrixImpl(nameID);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00026C38 File Offset: 0x00024E38
		public static Texture GetGlobalTexture(string name)
		{
			return Shader.GetGlobalTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00026C58 File Offset: 0x00024E58
		public static Texture GetGlobalTexture(int nameID)
		{
			return Shader.GetGlobalTextureImpl(nameID);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00026C70 File Offset: 0x00024E70
		public static Il2CppStructArray<float> GetGlobalFloatArray(string name)
		{
			return Shader.GetGlobalFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00026C90 File Offset: 0x00024E90
		public static Il2CppStructArray<float> GetGlobalFloatArray(int nameID)
		{
			return (Shader.GetGlobalFloatArrayCountImpl(nameID) != 0) ? Shader.GetGlobalFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00026CB4 File Offset: 0x00024EB4
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(string name)
		{
			return Shader.GetGlobalVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00026CD4 File Offset: 0x00024ED4
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(int nameID)
		{
			return (Shader.GetGlobalVectorArrayCountImpl(nameID) != 0) ? Shader.GetGlobalVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00026CF8 File Offset: 0x00024EF8
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(string name)
		{
			return Shader.GetGlobalMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00026D18 File Offset: 0x00024F18
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(int nameID)
		{
			return (Shader.GetGlobalMatrixArrayCountImpl(nameID) != 0) ? Shader.GetGlobalMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000066CF File Offset: 0x000048CF
		public static void GetGlobalFloatArray(string name, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000066DF File Offset: 0x000048DF
		public static void GetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(nameID, values);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000066EA File Offset: 0x000048EA
		public static void GetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000066FA File Offset: 0x000048FA
		public static void GetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(nameID, values);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00006705 File Offset: 0x00004905
		public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00006715 File Offset: 0x00004915
		public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(nameID, values);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00026D3C File Offset: 0x00024F3C
		public static string GetPropertyName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00006720 File Offset: 0x00004920
		public static int GetPropertyNameId(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyNameIdDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00006733 File Offset: 0x00004933
		public static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00026D64 File Offset: 0x00024F64
		public static string GetPropertyDescription(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyDescriptionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00006746 File Offset: 0x00004946
		public static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00026D8C File Offset: 0x00024F8C
		public static Il2CppStringArray GetPropertyAttributes(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyAttributesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00006759 File Offset: 0x00004959
		public static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyDefaultIntValueDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00026DBC File Offset: 0x00024FBC
		public static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex)
		{
			Vector4 vector;
			Shader.GetPropertyDefaultValue_Injected(shader, propertyIndex, out vector);
			return vector;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000676C File Offset: 0x0000496C
		public static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00026DD4 File Offset: 0x00024FD4
		public static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyTextureDefaultNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00026DFC File Offset: 0x00024FFC
		public unsafe static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex)
		{
			Shader.FindTextureStackImplDelegate findTextureStackImplDelegateField = Shader.FindTextureStackImplDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(stackName);
			return findTextureStackImplDelegateField(intPtr, propertyIdx, &intPtr2, out layerIndex);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00026E28 File Offset: 0x00025028
		public static void CheckPropertyIndex(Shader s, int propertyIndex)
		{
			bool flag = propertyIndex < 0 || propertyIndex >= s.GetPropertyCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("propertyIndex");
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000677F File Offset: 0x0000497F
		public int GetPropertyCount()
		{
			return Shader.GetPropertyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00006791 File Offset: 0x00004991
		public int FindPropertyIndex(string propertyName)
		{
			return Shader.FindPropertyIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00026E58 File Offset: 0x00025058
		public string GetPropertyName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyName(this, propertyIndex);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00026E7C File Offset: 0x0002507C
		public int GetPropertyNameId(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyNameId(this, propertyIndex);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00026EA0 File Offset: 0x000250A0
		public UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyType(this, propertyIndex);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00026EC4 File Offset: 0x000250C4
		public string GetPropertyDescription(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyDescription(this, propertyIndex);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00026EE8 File Offset: 0x000250E8
		public UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyFlags(this, propertyIndex);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00026F0C File Offset: 0x0002510C
		public Il2CppStringArray GetPropertyAttributes(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyAttributes(this, propertyIndex);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00026F30 File Offset: 0x00025130
		public float GetPropertyDefaultFloatValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Float && propertyType != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Float or Range.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex)[0];
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00026F80 File Offset: 0x00025180
		public Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Color && propertyType != UnityEngine.Rendering.ShaderPropertyType.Vector;
			if (flag)
			{
				throw new ArgumentException("Property type is not Color or Vector.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00026FC8 File Offset: 0x000251C8
		public Vector2 GetPropertyRangeLimits(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Range.");
			}
			Vector4 propertyDefaultValue = Shader.GetPropertyDefaultValue(this, propertyIndex);
			return new Vector2(propertyDefaultValue[1], propertyDefaultValue[2]);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002701C File Offset: 0x0002521C
		public UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not TexEnv.");
			}
			return Shader.GetPropertyTextureDimension(this, propertyIndex);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002705C File Offset: 0x0002525C
		public string GetPropertyTextureDefaultName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.GetPropertyTextureDefaultName(this, propertyIndex);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002709C File Offset: 0x0002529C
		public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.FindTextureStackImpl(this, propertyIndex, out stackName, out layerIndex);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000067A9 File Offset: 0x000049A9
		public static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
		{
			Shader.SetGlobalVectorImpl_InjectedDelegateField(name, ref value);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000067B7 File Offset: 0x000049B7
		public static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_InjectedDelegateField(name, ref value);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000067C5 File Offset: 0x000049C5
		public static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
		{
			Shader.GetGlobalVectorImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000067D3 File Offset: 0x000049D3
		public static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Shader.GetGlobalMatrixImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000067E1 File Offset: 0x000049E1
		public static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret)
		{
			Shader.GetPropertyDefaultValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex, out ret);
		}

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Shader_String_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400049E RID: 1182
		private static readonly Shader.FindBuiltinDelegate FindBuiltinDelegateField;

		// Token: 0x0400049F RID: 1183
		private static readonly Shader.get_maximumLODDelegate get_maximumLODDelegateField;

		// Token: 0x040004A0 RID: 1184
		private static readonly Shader.set_maximumLODDelegate set_maximumLODDelegateField;

		// Token: 0x040004A1 RID: 1185
		private static readonly Shader.get_globalMaximumLODDelegate get_globalMaximumLODDelegateField;

		// Token: 0x040004A2 RID: 1186
		private static readonly Shader.set_globalMaximumLODDelegate set_globalMaximumLODDelegateField;

		// Token: 0x040004A3 RID: 1187
		private static readonly Shader.get_isSupportedDelegate get_isSupportedDelegateField;

		// Token: 0x040004A4 RID: 1188
		private static readonly Shader.get_globalRenderPipelineDelegate get_globalRenderPipelineDelegateField;

		// Token: 0x040004A5 RID: 1189
		private static readonly Shader.set_globalRenderPipelineDelegate set_globalRenderPipelineDelegateField;

		// Token: 0x040004A6 RID: 1190
		private static readonly Shader.EnableKeywordDelegate EnableKeywordDelegateField;

		// Token: 0x040004A7 RID: 1191
		private static readonly Shader.DisableKeywordDelegate DisableKeywordDelegateField;

		// Token: 0x040004A8 RID: 1192
		private static readonly Shader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x040004A9 RID: 1193
		private static readonly Shader.get_renderQueueDelegate get_renderQueueDelegateField;

		// Token: 0x040004AA RID: 1194
		private static readonly Shader.get_disableBatchingDelegate get_disableBatchingDelegateField;

		// Token: 0x040004AB RID: 1195
		private static readonly Shader.WarmupAllShadersDelegate WarmupAllShadersDelegateField;

		// Token: 0x040004AC RID: 1196
		private static readonly Shader.IDToTagDelegate IDToTagDelegateField;

		// Token: 0x040004AD RID: 1197
		private static readonly Shader.GetDependencyDelegate GetDependencyDelegateField;

		// Token: 0x040004AE RID: 1198
		private static readonly Shader.get_passCountDelegate get_passCountDelegateField;

		// Token: 0x040004AF RID: 1199
		private static readonly Shader.Internal_FindPassTagValueDelegate Internal_FindPassTagValueDelegateField;

		// Token: 0x040004B0 RID: 1200
		private static readonly Shader.SetGlobalIntImplDelegate SetGlobalIntImplDelegateField;

		// Token: 0x040004B1 RID: 1201
		private static readonly Shader.SetGlobalFloatImplDelegate SetGlobalFloatImplDelegateField;

		// Token: 0x040004B2 RID: 1202
		private static readonly Shader.SetGlobalTextureImplDelegate SetGlobalTextureImplDelegateField;

		// Token: 0x040004B3 RID: 1203
		private static readonly Shader.SetGlobalRenderTextureImplDelegate SetGlobalRenderTextureImplDelegateField;

		// Token: 0x040004B4 RID: 1204
		private static readonly Shader.SetGlobalBufferImplDelegate SetGlobalBufferImplDelegateField;

		// Token: 0x040004B5 RID: 1205
		private static readonly Shader.SetGlobalGraphicsBufferImplDelegate SetGlobalGraphicsBufferImplDelegateField;

		// Token: 0x040004B6 RID: 1206
		private static readonly Shader.SetGlobalConstantBufferImplDelegate SetGlobalConstantBufferImplDelegateField;

		// Token: 0x040004B7 RID: 1207
		private static readonly Shader.SetGlobalConstantGraphicsBufferImplDelegate SetGlobalConstantGraphicsBufferImplDelegateField;

		// Token: 0x040004B8 RID: 1208
		private static readonly Shader.GetGlobalIntImplDelegate GetGlobalIntImplDelegateField;

		// Token: 0x040004B9 RID: 1209
		private static readonly Shader.GetGlobalFloatImplDelegate GetGlobalFloatImplDelegateField;

		// Token: 0x040004BA RID: 1210
		private static readonly Shader.GetGlobalTextureImplDelegate GetGlobalTextureImplDelegateField;

		// Token: 0x040004BB RID: 1211
		private static readonly Shader.SetGlobalFloatArrayImplDelegate SetGlobalFloatArrayImplDelegateField;

		// Token: 0x040004BC RID: 1212
		private static readonly Shader.SetGlobalVectorArrayImplDelegate SetGlobalVectorArrayImplDelegateField;

		// Token: 0x040004BD RID: 1213
		private static readonly Shader.SetGlobalMatrixArrayImplDelegate SetGlobalMatrixArrayImplDelegateField;

		// Token: 0x040004BE RID: 1214
		private static readonly Shader.GetGlobalFloatArrayImplDelegate GetGlobalFloatArrayImplDelegateField;

		// Token: 0x040004BF RID: 1215
		private static readonly Shader.GetGlobalVectorArrayImplDelegate GetGlobalVectorArrayImplDelegateField;

		// Token: 0x040004C0 RID: 1216
		private static readonly Shader.GetGlobalMatrixArrayImplDelegate GetGlobalMatrixArrayImplDelegateField;

		// Token: 0x040004C1 RID: 1217
		private static readonly Shader.GetGlobalFloatArrayCountImplDelegate GetGlobalFloatArrayCountImplDelegateField;

		// Token: 0x040004C2 RID: 1218
		private static readonly Shader.GetGlobalVectorArrayCountImplDelegate GetGlobalVectorArrayCountImplDelegateField;

		// Token: 0x040004C3 RID: 1219
		private static readonly Shader.GetGlobalMatrixArrayCountImplDelegate GetGlobalMatrixArrayCountImplDelegateField;

		// Token: 0x040004C4 RID: 1220
		private static readonly Shader.ExtractGlobalFloatArrayImplDelegate ExtractGlobalFloatArrayImplDelegateField;

		// Token: 0x040004C5 RID: 1221
		private static readonly Shader.ExtractGlobalVectorArrayImplDelegate ExtractGlobalVectorArrayImplDelegateField;

		// Token: 0x040004C6 RID: 1222
		private static readonly Shader.ExtractGlobalMatrixArrayImplDelegate ExtractGlobalMatrixArrayImplDelegateField;

		// Token: 0x040004C7 RID: 1223
		private static readonly Shader.GetPropertyNameDelegate GetPropertyNameDelegateField;

		// Token: 0x040004C8 RID: 1224
		private static readonly Shader.GetPropertyNameIdDelegate GetPropertyNameIdDelegateField;

		// Token: 0x040004C9 RID: 1225
		private static readonly Shader.GetPropertyTypeDelegate GetPropertyTypeDelegateField;

		// Token: 0x040004CA RID: 1226
		private static readonly Shader.GetPropertyDescriptionDelegate GetPropertyDescriptionDelegateField;

		// Token: 0x040004CB RID: 1227
		private static readonly Shader.GetPropertyFlagsDelegate GetPropertyFlagsDelegateField;

		// Token: 0x040004CC RID: 1228
		private static readonly Shader.GetPropertyAttributesDelegate GetPropertyAttributesDelegateField;

		// Token: 0x040004CD RID: 1229
		private static readonly Shader.GetPropertyDefaultIntValueDelegate GetPropertyDefaultIntValueDelegateField;

		// Token: 0x040004CE RID: 1230
		private static readonly Shader.GetPropertyTextureDimensionDelegate GetPropertyTextureDimensionDelegateField;

		// Token: 0x040004CF RID: 1231
		private static readonly Shader.GetPropertyTextureDefaultNameDelegate GetPropertyTextureDefaultNameDelegateField;

		// Token: 0x040004D0 RID: 1232
		private static readonly Shader.FindTextureStackImplDelegate FindTextureStackImplDelegateField;

		// Token: 0x040004D1 RID: 1233
		private static readonly Shader.GetPropertyCountDelegate GetPropertyCountDelegateField;

		// Token: 0x040004D2 RID: 1234
		private static readonly Shader.FindPropertyIndexDelegate FindPropertyIndexDelegateField;

		// Token: 0x040004D3 RID: 1235
		private static readonly Shader.SetGlobalVectorImpl_InjectedDelegate SetGlobalVectorImpl_InjectedDelegateField;

		// Token: 0x040004D4 RID: 1236
		private static readonly Shader.SetGlobalMatrixImpl_InjectedDelegate SetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x040004D5 RID: 1237
		private static readonly Shader.GetGlobalVectorImpl_InjectedDelegate GetGlobalVectorImpl_InjectedDelegateField;

		// Token: 0x040004D6 RID: 1238
		private static readonly Shader.GetGlobalMatrixImpl_InjectedDelegate GetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x040004D7 RID: 1239
		private static readonly Shader.GetPropertyDefaultValue_InjectedDelegate GetPropertyDefaultValue_InjectedDelegateField;

		// Token: 0x02000551 RID: 1361
		// (Invoke) Token: 0x06002871 RID: 10353
		private delegate IntPtr FindBuiltinDelegate(IntPtr name);

		// Token: 0x02000552 RID: 1362
		// (Invoke) Token: 0x06002873 RID: 10355
		private delegate int get_maximumLODDelegate(IntPtr @this);

		// Token: 0x02000553 RID: 1363
		// (Invoke) Token: 0x06002875 RID: 10357
		private delegate void set_maximumLODDelegate(IntPtr @this, int value);

		// Token: 0x02000554 RID: 1364
		// (Invoke) Token: 0x06002877 RID: 10359
		private delegate int get_globalMaximumLODDelegate();

		// Token: 0x02000555 RID: 1365
		// (Invoke) Token: 0x06002879 RID: 10361
		private delegate void set_globalMaximumLODDelegate(int value);

		// Token: 0x02000556 RID: 1366
		// (Invoke) Token: 0x0600287B RID: 10363
		private delegate bool get_isSupportedDelegate(IntPtr @this);

		// Token: 0x02000557 RID: 1367
		// (Invoke) Token: 0x0600287D RID: 10365
		private delegate IntPtr get_globalRenderPipelineDelegate();

		// Token: 0x02000558 RID: 1368
		// (Invoke) Token: 0x0600287F RID: 10367
		private delegate void set_globalRenderPipelineDelegate(IntPtr value);

		// Token: 0x02000559 RID: 1369
		// (Invoke) Token: 0x06002881 RID: 10369
		private delegate void EnableKeywordDelegate(IntPtr keyword);

		// Token: 0x0200055A RID: 1370
		// (Invoke) Token: 0x06002883 RID: 10371
		private delegate void DisableKeywordDelegate(IntPtr keyword);

		// Token: 0x0200055B RID: 1371
		// (Invoke) Token: 0x06002885 RID: 10373
		private delegate bool IsKeywordEnabledDelegate(IntPtr keyword);

		// Token: 0x0200055C RID: 1372
		// (Invoke) Token: 0x06002887 RID: 10375
		private delegate int get_renderQueueDelegate(IntPtr @this);

		// Token: 0x0200055D RID: 1373
		// (Invoke) Token: 0x06002889 RID: 10377
		private delegate DisableBatchingType get_disableBatchingDelegate(IntPtr @this);

		// Token: 0x0200055E RID: 1374
		// (Invoke) Token: 0x0600288B RID: 10379
		private delegate void WarmupAllShadersDelegate();

		// Token: 0x0200055F RID: 1375
		// (Invoke) Token: 0x0600288D RID: 10381
		private delegate IntPtr IDToTagDelegate(int name);

		// Token: 0x02000560 RID: 1376
		// (Invoke) Token: 0x0600288F RID: 10383
		private delegate IntPtr GetDependencyDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000561 RID: 1377
		// (Invoke) Token: 0x06002891 RID: 10385
		private delegate int get_passCountDelegate(IntPtr @this);

		// Token: 0x02000562 RID: 1378
		// (Invoke) Token: 0x06002893 RID: 10387
		private delegate int Internal_FindPassTagValueDelegate(IntPtr @this, int passIndex, int tagName);

		// Token: 0x02000563 RID: 1379
		// (Invoke) Token: 0x06002895 RID: 10389
		private delegate void SetGlobalIntImplDelegate(int name, int value);

		// Token: 0x02000564 RID: 1380
		// (Invoke) Token: 0x06002897 RID: 10391
		private delegate void SetGlobalFloatImplDelegate(int name, float value);

		// Token: 0x02000565 RID: 1381
		// (Invoke) Token: 0x06002899 RID: 10393
		private delegate void SetGlobalTextureImplDelegate(int name, IntPtr value);

		// Token: 0x02000566 RID: 1382
		// (Invoke) Token: 0x0600289B RID: 10395
		private delegate void SetGlobalRenderTextureImplDelegate(int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x02000567 RID: 1383
		// (Invoke) Token: 0x0600289D RID: 10397
		private delegate void SetGlobalBufferImplDelegate(int name, IntPtr value);

		// Token: 0x02000568 RID: 1384
		// (Invoke) Token: 0x0600289F RID: 10399
		private delegate void SetGlobalGraphicsBufferImplDelegate(int name, IntPtr value);

		// Token: 0x02000569 RID: 1385
		// (Invoke) Token: 0x060028A1 RID: 10401
		private delegate void SetGlobalConstantBufferImplDelegate(int name, IntPtr value, int offset, int size);

		// Token: 0x0200056A RID: 1386
		// (Invoke) Token: 0x060028A3 RID: 10403
		private delegate void SetGlobalConstantGraphicsBufferImplDelegate(int name, IntPtr value, int offset, int size);

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x060028A5 RID: 10405
		private delegate int GetGlobalIntImplDelegate(int name);

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x060028A7 RID: 10407
		private delegate float GetGlobalFloatImplDelegate(int name);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x060028A9 RID: 10409
		private delegate IntPtr GetGlobalTextureImplDelegate(int name);

		// Token: 0x0200056E RID: 1390
		// (Invoke) Token: 0x060028AB RID: 10411
		private delegate void SetGlobalFloatArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x0200056F RID: 1391
		// (Invoke) Token: 0x060028AD RID: 10413
		private delegate void SetGlobalVectorArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x02000570 RID: 1392
		// (Invoke) Token: 0x060028AF RID: 10415
		private delegate void SetGlobalMatrixArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x02000571 RID: 1393
		// (Invoke) Token: 0x060028B1 RID: 10417
		private delegate IntPtr GetGlobalFloatArrayImplDelegate(int name);

		// Token: 0x02000572 RID: 1394
		// (Invoke) Token: 0x060028B3 RID: 10419
		private delegate IntPtr GetGlobalVectorArrayImplDelegate(int name);

		// Token: 0x02000573 RID: 1395
		// (Invoke) Token: 0x060028B5 RID: 10421
		private delegate IntPtr GetGlobalMatrixArrayImplDelegate(int name);

		// Token: 0x02000574 RID: 1396
		// (Invoke) Token: 0x060028B7 RID: 10423
		private delegate int GetGlobalFloatArrayCountImplDelegate(int name);

		// Token: 0x02000575 RID: 1397
		// (Invoke) Token: 0x060028B9 RID: 10425
		private delegate int GetGlobalVectorArrayCountImplDelegate(int name);

		// Token: 0x02000576 RID: 1398
		// (Invoke) Token: 0x060028BB RID: 10427
		private delegate int GetGlobalMatrixArrayCountImplDelegate(int name);

		// Token: 0x02000577 RID: 1399
		// (Invoke) Token: 0x060028BD RID: 10429
		private delegate void ExtractGlobalFloatArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x02000578 RID: 1400
		// (Invoke) Token: 0x060028BF RID: 10431
		private delegate void ExtractGlobalVectorArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x02000579 RID: 1401
		// (Invoke) Token: 0x060028C1 RID: 10433
		private delegate void ExtractGlobalMatrixArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x0200057A RID: 1402
		// (Invoke) Token: 0x060028C3 RID: 10435
		private delegate IntPtr GetPropertyNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x0200057B RID: 1403
		// (Invoke) Token: 0x060028C5 RID: 10437
		private delegate int GetPropertyNameIdDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x060028C7 RID: 10439
		private delegate UnityEngine.Rendering.ShaderPropertyType GetPropertyTypeDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x060028C9 RID: 10441
		private delegate IntPtr GetPropertyDescriptionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x060028CB RID: 10443
		private delegate UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlagsDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x060028CD RID: 10445
		private delegate IntPtr GetPropertyAttributesDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x060028CF RID: 10447
		private delegate int GetPropertyDefaultIntValueDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x060028D1 RID: 10449
		private delegate UnityEngine.Rendering.TextureDimension GetPropertyTextureDimensionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x060028D3 RID: 10451
		private delegate IntPtr GetPropertyTextureDefaultNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x02000583 RID: 1411
		// (Invoke) Token: 0x060028D5 RID: 10453
		private delegate bool FindTextureStackImplDelegate(IntPtr s, int propertyIdx, [Out] IntPtr stackName, [Out] IntPtr layerIndex);

		// Token: 0x02000584 RID: 1412
		// (Invoke) Token: 0x060028D7 RID: 10455
		private delegate int GetPropertyCountDelegate(IntPtr @this);

		// Token: 0x02000585 RID: 1413
		// (Invoke) Token: 0x060028D9 RID: 10457
		private delegate int FindPropertyIndexDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x02000586 RID: 1414
		// (Invoke) Token: 0x060028DB RID: 10459
		private delegate void SetGlobalVectorImpl_InjectedDelegate(int name, IntPtr value);

		// Token: 0x02000587 RID: 1415
		// (Invoke) Token: 0x060028DD RID: 10461
		private delegate void SetGlobalMatrixImpl_InjectedDelegate(int name, IntPtr value);

		// Token: 0x02000588 RID: 1416
		// (Invoke) Token: 0x060028DF RID: 10463
		private delegate void GetGlobalVectorImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x02000589 RID: 1417
		// (Invoke) Token: 0x060028E1 RID: 10465
		private delegate void GetGlobalMatrixImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x0200058A RID: 1418
		// (Invoke) Token: 0x060028E3 RID: 10467
		private delegate void GetPropertyDefaultValue_InjectedDelegate(IntPtr shader, int propertyIndex, [Out] IntPtr ret);
	}
}
