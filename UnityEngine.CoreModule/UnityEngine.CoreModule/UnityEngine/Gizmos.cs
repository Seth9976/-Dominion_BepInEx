using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	public sealed class Gizmos : Object
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00021DD8 File Offset: 0x0001FFD8
		// Note: this type is marked as 'beforefieldinit'.
		static Gizmos()
		{
			Il2CppClassPointerStore<Gizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gizmos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmos>.NativeClassPtr);
			Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663575);
			Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663576);
			Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663577);
			Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmos>.NativeClassPtr, 100663578);
			Gizmos.get_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.get_exposureDelegate>("UnityEngine.Gizmos::get_exposure");
			Gizmos.set_exposureDelegateField = IL2CPP.ResolveICall<Gizmos.set_exposureDelegate>("UnityEngine.Gizmos::set_exposure");
			Gizmos.get_probeSizeDelegateField = IL2CPP.ResolveICall<Gizmos.get_probeSizeDelegate>("UnityEngine.Gizmos::get_probeSize");
			Gizmos.DrawWireSphere_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawWireSphere_InjectedDelegate>("UnityEngine.Gizmos::DrawWireSphere_Injected");
			Gizmos.DrawSphere_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawSphere_InjectedDelegate>("UnityEngine.Gizmos::DrawSphere_Injected");
			Gizmos.DrawWireCube_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawWireCube_InjectedDelegate>("UnityEngine.Gizmos::DrawWireCube_Injected");
			Gizmos.DrawCube_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawCube_InjectedDelegate>("UnityEngine.Gizmos::DrawCube_Injected");
			Gizmos.DrawMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawMesh_Injected");
			Gizmos.DrawWireMesh_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawWireMesh_InjectedDelegate>("UnityEngine.Gizmos::DrawWireMesh_Injected");
			Gizmos.DrawIcon_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawIcon_InjectedDelegate>("UnityEngine.Gizmos::DrawIcon_Injected");
			Gizmos.DrawGUITexture_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawGUITexture_InjectedDelegate>("UnityEngine.Gizmos::DrawGUITexture_Injected");
			Gizmos.get_color_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_color_InjectedDelegate>("UnityEngine.Gizmos::get_color_Injected");
			Gizmos.get_matrix_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.get_matrix_InjectedDelegate>("UnityEngine.Gizmos::get_matrix_Injected");
			Gizmos.set_matrix_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.set_matrix_InjectedDelegate>("UnityEngine.Gizmos::set_matrix_Injected");
			Gizmos.DrawFrustum_InjectedDelegateField = IL2CPP.ResolveICall<Gizmos.DrawFrustum_InjectedDelegate>("UnityEngine.Gizmos::DrawFrustum_Injected");
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00021F3C File Offset: 0x0002013C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62454, RefRangeEnd = 62458, XrefRangeStart = 62452, XrefRangeEnd = 62454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 from, Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00022024 File Offset: 0x00020224
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00021F7C File Offset: 0x0002017C
		public unsafe static Color color
		{
			get
			{
				Color color;
				Gizmos.get_color_Injected(out color);
				return color;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62460, RefRangeEnd = 62464, XrefRangeStart = 62458, XrefRangeEnd = 62460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00021FB0 File Offset: 0x000201B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62464, XrefRangeEnd = 62466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00021FF0 File Offset: 0x000201F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62466, XrefRangeEnd = 62468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_color_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmos.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004C2A File Offset: 0x00002E2A
		public Gizmos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00004C33 File Offset: 0x00002E33
		public static void DrawWireSphere(Vector3 center, float radius)
		{
			Gizmos.DrawWireSphere_Injected(ref center, radius);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004C3D File Offset: 0x00002E3D
		public static void DrawSphere(Vector3 center, float radius)
		{
			Gizmos.DrawSphere_Injected(ref center, radius);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004C47 File Offset: 0x00002E47
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
			Gizmos.DrawWireCube_Injected(ref center, ref size);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00004C52 File Offset: 0x00002E52
		public static void DrawCube(Vector3 center, Vector3 size)
		{
			Gizmos.DrawCube_Injected(ref center, ref size);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004C5D File Offset: 0x00002E5D
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004C6C File Offset: 0x00002E6C
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh_Injected(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004C7B File Offset: 0x00002E7B
		public static void DrawIcon(Vector3 center, string name, bool allowScaling)
		{
			Gizmos.DrawIcon(center, name, allowScaling, Color.white);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004C8C File Offset: 0x00002E8C
		public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint)
		{
			Gizmos.DrawIcon_Injected(ref center, name, allowScaling, ref tint);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00004C99 File Offset: 0x00002E99
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_Injected(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002203C File Offset: 0x0002023C
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00004CAB File Offset: 0x00002EAB
		public static Matrix4x4 matrix
		{
			get
			{
				Matrix4x4 matrix4x;
				Gizmos.get_matrix_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				Gizmos.set_matrix_Injected(ref value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00022054 File Offset: 0x00020254
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00004CB4 File Offset: 0x00002EB4
		public static Texture exposure
		{
			get
			{
				IntPtr intPtr = Gizmos.get_exposureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				Gizmos.set_exposureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00004CC6 File Offset: 0x00002EC6
		public static float probeSize
		{
			get
			{
				return Gizmos.get_probeSizeDelegateField();
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004CD2 File Offset: 0x00002ED2
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_Injected(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004D03 File Offset: 0x00002F03
		public static void DrawRay(Vector3 from, Vector3 direction)
		{
			Gizmos.DrawLine(from, from + direction);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0002207C File Offset: 0x0002027C
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002209C File Offset: 0x0002029C
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000220C0 File Offset: 0x000202C0
		public static void DrawMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, zero, identity, one);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004D14 File Offset: 0x00002F14
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000220EC File Offset: 0x000202EC
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002210C File Offset: 0x0002030C
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00022134 File Offset: 0x00020334
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00022160 File Offset: 0x00020360
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00022180 File Offset: 0x00020380
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000221A4 File Offset: 0x000203A4
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004D22 File Offset: 0x00002F22
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			Gizmos.DrawWireMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000221D0 File Offset: 0x000203D0
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, rotation, one);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000221F0 File Offset: 0x000203F0
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, submeshIndex, position, identity, one);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00022218 File Offset: 0x00020418
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, submeshIndex, zero, identity, one);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00022244 File Offset: 0x00020444
		public static void DrawIcon(Vector3 center, string name)
		{
			bool flag = true;
			Gizmos.DrawIcon(center, name, flag);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00022260 File Offset: 0x00020460
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, material);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00004D30 File Offset: 0x00002F30
		public static void DrawGUITexture(Rect screenRect, Texture texture, Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0002227C File Offset: 0x0002047C
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material material = null;
			Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00004D40 File Offset: 0x00002F40
		public static void DrawWireSphere_Injected(ref Vector3 center, float radius)
		{
			Gizmos.DrawWireSphere_InjectedDelegateField(ref center, radius);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00004D4E File Offset: 0x00002F4E
		public static void DrawSphere_Injected(ref Vector3 center, float radius)
		{
			Gizmos.DrawSphere_InjectedDelegateField(ref center, radius);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00004D5C File Offset: 0x00002F5C
		public static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			Gizmos.DrawWireCube_InjectedDelegateField(ref center, ref size);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00004D6A File Offset: 0x00002F6A
		public static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
		{
			Gizmos.DrawCube_InjectedDelegateField(ref center, ref size);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00004D78 File Offset: 0x00002F78
		public static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00004D8F File Offset: 0x00002F8F
		public static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
		{
			Gizmos.DrawWireMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint)
		{
			Gizmos.DrawIcon_InjectedDelegateField(ref center, IL2CPP.ManagedStringToIl2Cpp(name), allowScaling, ref tint);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00004DBB File Offset: 0x00002FBB
		public static void DrawGUITexture_Injected(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Gizmos.DrawGUITexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), leftBorder, rightBorder, topBorder, bottomBorder, IL2CPP.Il2CppObjectBaseToPtr(mat));
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00004DDB File Offset: 0x00002FDB
		public static void get_color_Injected(out Color ret)
		{
			Gizmos.get_color_InjectedDelegateField(out ret);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public static void get_matrix_Injected(out Matrix4x4 ret)
		{
			Gizmos.get_matrix_InjectedDelegateField(out ret);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004DF5 File Offset: 0x00002FF5
		public static void set_matrix_Injected(ref Matrix4x4 value)
		{
			Gizmos.set_matrix_InjectedDelegateField(ref value);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004E02 File Offset: 0x00003002
		public static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.DrawFrustum_InjectedDelegateField(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Static_set_Void_Color_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000345 RID: 837
		private static readonly Gizmos.get_exposureDelegate get_exposureDelegateField;

		// Token: 0x04000346 RID: 838
		private static readonly Gizmos.set_exposureDelegate set_exposureDelegateField;

		// Token: 0x04000347 RID: 839
		private static readonly Gizmos.get_probeSizeDelegate get_probeSizeDelegateField;

		// Token: 0x04000348 RID: 840
		private static readonly Gizmos.DrawWireSphere_InjectedDelegate DrawWireSphere_InjectedDelegateField;

		// Token: 0x04000349 RID: 841
		private static readonly Gizmos.DrawSphere_InjectedDelegate DrawSphere_InjectedDelegateField;

		// Token: 0x0400034A RID: 842
		private static readonly Gizmos.DrawWireCube_InjectedDelegate DrawWireCube_InjectedDelegateField;

		// Token: 0x0400034B RID: 843
		private static readonly Gizmos.DrawCube_InjectedDelegate DrawCube_InjectedDelegateField;

		// Token: 0x0400034C RID: 844
		private static readonly Gizmos.DrawMesh_InjectedDelegate DrawMesh_InjectedDelegateField;

		// Token: 0x0400034D RID: 845
		private static readonly Gizmos.DrawWireMesh_InjectedDelegate DrawWireMesh_InjectedDelegateField;

		// Token: 0x0400034E RID: 846
		private static readonly Gizmos.DrawIcon_InjectedDelegate DrawIcon_InjectedDelegateField;

		// Token: 0x0400034F RID: 847
		private static readonly Gizmos.DrawGUITexture_InjectedDelegate DrawGUITexture_InjectedDelegateField;

		// Token: 0x04000350 RID: 848
		private static readonly Gizmos.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000351 RID: 849
		private static readonly Gizmos.get_matrix_InjectedDelegate get_matrix_InjectedDelegateField;

		// Token: 0x04000352 RID: 850
		private static readonly Gizmos.set_matrix_InjectedDelegate set_matrix_InjectedDelegateField;

		// Token: 0x04000353 RID: 851
		private static readonly Gizmos.DrawFrustum_InjectedDelegate DrawFrustum_InjectedDelegateField;

		// Token: 0x02000445 RID: 1093
		// (Invoke) Token: 0x0600264F RID: 9807
		private delegate IntPtr get_exposureDelegate();

		// Token: 0x02000446 RID: 1094
		// (Invoke) Token: 0x06002651 RID: 9809
		private delegate void set_exposureDelegate(IntPtr value);

		// Token: 0x02000447 RID: 1095
		// (Invoke) Token: 0x06002653 RID: 9811
		private delegate float get_probeSizeDelegate();

		// Token: 0x02000448 RID: 1096
		// (Invoke) Token: 0x06002655 RID: 9813
		private delegate void DrawWireSphere_InjectedDelegate(IntPtr center, float radius);

		// Token: 0x02000449 RID: 1097
		// (Invoke) Token: 0x06002657 RID: 9815
		private delegate void DrawSphere_InjectedDelegate(IntPtr center, float radius);

		// Token: 0x0200044A RID: 1098
		// (Invoke) Token: 0x06002659 RID: 9817
		private delegate void DrawWireCube_InjectedDelegate(IntPtr center, IntPtr size);

		// Token: 0x0200044B RID: 1099
		// (Invoke) Token: 0x0600265B RID: 9819
		private delegate void DrawCube_InjectedDelegate(IntPtr center, IntPtr size);

		// Token: 0x0200044C RID: 1100
		// (Invoke) Token: 0x0600265D RID: 9821
		private delegate void DrawMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x0200044D RID: 1101
		// (Invoke) Token: 0x0600265F RID: 9823
		private delegate void DrawWireMesh_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr position, IntPtr rotation, IntPtr scale);

		// Token: 0x0200044E RID: 1102
		// (Invoke) Token: 0x06002661 RID: 9825
		private delegate void DrawIcon_InjectedDelegate(IntPtr center, IntPtr name, bool allowScaling, IntPtr tint);

		// Token: 0x0200044F RID: 1103
		// (Invoke) Token: 0x06002663 RID: 9827
		private delegate void DrawGUITexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, IntPtr mat);

		// Token: 0x02000450 RID: 1104
		// (Invoke) Token: 0x06002665 RID: 9829
		private delegate void get_color_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000451 RID: 1105
		// (Invoke) Token: 0x06002667 RID: 9831
		private delegate void get_matrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000452 RID: 1106
		// (Invoke) Token: 0x06002669 RID: 9833
		private delegate void set_matrix_InjectedDelegate(IntPtr value);

		// Token: 0x02000453 RID: 1107
		// (Invoke) Token: 0x0600266B RID: 9835
		private delegate void DrawFrustum_InjectedDelegate(IntPtr center, float fov, float maxRange, float minRange, float aspect);
	}
}
