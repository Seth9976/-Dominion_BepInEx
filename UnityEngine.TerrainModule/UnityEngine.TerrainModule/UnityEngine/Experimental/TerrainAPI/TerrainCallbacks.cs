using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000004 RID: 4
	public static class TerrainCallbacks : Object
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000052D8 File Offset: 0x000034D8
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainCallbacks()
		{
			Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Experimental.TerrainAPI", "TerrainCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr);
			TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "heightmapChanged");
			TerrainCallbacks.NativeFieldInfoPtr_textureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "textureChanged");
			TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663311);
			TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, 100663312);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005358 File Offset: 0x00003558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157760, XrefRangeEnd = 157767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000053AC File Offset: 0x000035AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157767, XrefRangeEnd = 157774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrainData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002B13 File Offset: 0x00000D13
		public TerrainCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005410 File Offset: 0x00003610
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002B1C File Offset: 0x00000D1C
		public unsafe static TerrainCallbacks.HeightmapChangedCallback heightmapChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.HeightmapChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_heightmapChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005438 File Offset: 0x00003638
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002B2E File Offset: 0x00000D2E
		public unsafe static TerrainCallbacks.TextureChangedCallback textureChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainCallbacks.TextureChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerrainCallbacks.NativeFieldInfoPtr_textureChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002B40 File Offset: 0x00000D40
		public static void add_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002B4D File Offset: 0x00000D4D
		public static void remove_heightmapChanged(TerrainCallbacks.HeightmapChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002B5A File Offset: 0x00000D5A
		public static void add_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002B67 File Offset: 0x00000D67
		public static void remove_textureChanged(TerrainCallbacks.TextureChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_heightmapChanged;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_textureChanged;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_InvokeHeightmapChangedCallback_Internal_Static_Void_TerrainData_RectInt_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTextureChangedCallback_Internal_Static_Void_TerrainData_String_RectInt_Boolean_0;

		// Token: 0x020000A4 RID: 164
		public sealed class HeightmapChangedCallback : MulticastDelegate
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x000032C1 File Offset: 0x000014C1
			// Note: this type is marked as 'beforefieldinit'.
			static HeightmapChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "HeightmapChangedCallback");
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663313);
				TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr, 100663314);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000650C File Offset: 0x0000470C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeightmapChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.HeightmapChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00006568 File Offset: 0x00004768
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157739, RefRangeEnd = 157740, XrefRangeStart = 157719, XrefRangeEnd = 157739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Terrain terrain, RectInt heightRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightRegion;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.HeightmapChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CA RID: 714 RVA: 0x000032FF File Offset: 0x000014FF
			public HeightmapChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002CB RID: 715 RVA: 0x00003308 File Offset: 0x00001508
			public static implicit operator TerrainCallbacks.HeightmapChangedCallback(Action<Terrain, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.HeightmapChangedCallback>(A_0);
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00003310 File Offset: 0x00001510
			public static TerrainCallbacks.HeightmapChangedCallback operator +(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.HeightmapChangedCallback>();
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000331E File Offset: 0x0000151E
			public static TerrainCallbacks.HeightmapChangedCallback operator -(TerrainCallbacks.HeightmapChangedCallback A_0, TerrainCallbacks.HeightmapChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.HeightmapChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_RectInt_Boolean_0;
		}

		// Token: 0x020000A5 RID: 165
		public sealed class TextureChangedCallback : MulticastDelegate
		{
			// Token: 0x060002CE RID: 718 RVA: 0x0000332F File Offset: 0x0000152F
			// Note: this type is marked as 'beforefieldinit'.
			static TextureChangedCallback()
			{
				Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainCallbacks>.NativeClassPtr, "TextureChangedCallback");
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663315);
				TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr, 100663316);
			}

			// Token: 0x060002CF RID: 719 RVA: 0x000065C8 File Offset: 0x000047C8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureChangedCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainCallbacks.TextureChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00006624 File Offset: 0x00004824
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157759, RefRangeEnd = 157760, XrefRangeStart = 157740, XrefRangeEnd = 157759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textureName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref texelRegion;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synched;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainCallbacks.TextureChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000336D File Offset: 0x0000156D
			public TextureChangedCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00003376 File Offset: 0x00001576
			public static implicit operator TerrainCallbacks.TextureChangedCallback(Action<Terrain, string, RectInt, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<TerrainCallbacks.TextureChangedCallback>(A_0);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000337E File Offset: 0x0000157E
			public static TerrainCallbacks.TextureChangedCallback operator +(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TerrainCallbacks.TextureChangedCallback>();
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x0000338C File Offset: 0x0000158C
			public static TerrainCallbacks.TextureChangedCallback operator -(TerrainCallbacks.TextureChangedCallback A_0, TerrainCallbacks.TextureChangedCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TerrainCallbacks.TextureChangedCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Terrain_String_RectInt_Boolean_0;
		}
	}
}
